using Leiturinha.Data;
using Leiturinha.Helpers;
using Leiturinha.Models;
using Leiturinha.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Security.Claims;

namespace Leiturinha.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<Usuario> _signInManager;
    private readonly UserManager<Usuario> _userManager;
    private readonly IWebHostEnvironment _host;
    private readonly AppDbContext _db;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        IWebHostEnvironment host,
        AppDbContext db
    )
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
        _host = host;
        _db = db;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM login)
    {
        if (ModelState.IsValid)
        {
            string userName = login.Email;
            if (IsValidEmail(login.Email))
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                    userName = user.UserName;
            }

            var result = await _signInManager.PasswordSignInAsync(
                userName, login.Senha, login.Lembrar, lockoutOnFailure: true
            );

            if (result.Succeeded)
            {
                _logger.LogInformation($"Usuário {login.Email} acessou o sistema");
                TempData["LoginSuccess"] = "Login realizado com sucesso!";
                return RedirectToAction("Index", "Home");
            }

            if (result.IsLockedOut)
            {
                _logger.LogWarning($"Usuário {login.Email} está bloqueado");
                ModelState.AddModelError("", "Sua conta está bloqueada, aguarde alguns minutos e tente novamente!");
                TempData["LoginError"] = "Sua conta está bloqueada.";
            }
            else if (result.IsNotAllowed)
            {
                _logger.LogWarning($"Usuário {login.Email} não confirmou sua conta");
                ModelState.AddModelError(string.Empty, "Sua conta precisa ser confirmada antes de acessar.");
                TempData["LoginError"] = "Sua conta precisa ser confirmada.";
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuário e/ou Senha Inválidos!");
                TempData["LoginError"] = "Usuário e/ou Senha inválidos!";
            }
        }

        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        _logger.LogInformation($"Usuário {ClaimTypes.Email} fez logoff");
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Registro()
    {
        RegistroVM register = new();
        return View(register);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Registro(RegistroVM registro)
    {
        if (ModelState.IsValid)
        {
            var usuario = Activator.CreateInstance<Usuario>();
            usuario.Nome = registro.Nome;
            usuario.DataNascimento = registro.DataNascimento;
            usuario.UserName = registro.Email;
            usuario.NormalizedUserName = registro.Email.ToUpper();
            usuario.Email = registro.Email;
            usuario.NormalizedEmail = registro.Email.ToUpper();
            usuario.EmailConfirmed = true;

            var result = await _userManager.CreateAsync(usuario, registro.Senha);
            if (!result.Succeeded)
            {
                TempData["RegistroError"] = string.Join(" | ", result.Errors.Select(e => e.Description));
            }


            if (result.Succeeded)
            {
                _logger.LogInformation($"Novo usuário registrado com o email {registro.Email}.");

                await _userManager.AddToRoleAsync(usuario, "Cliente");

                if (registro.Foto != null && registro.Foto.Length > 0)
                {
                    string nomeArquivo = usuario.Id + Path.GetExtension(registro.Foto.FileName);
                    string pastaDestino = Path.Combine(_host.WebRootPath, "img", "usuarios");

                    if (!Directory.Exists(pastaDestino))
                        Directory.CreateDirectory(pastaDestino);

                    string caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    {
                        await registro.Foto.CopyToAsync(stream);
                    }

                    usuario.Foto = Path.Combine("/img/usuarios/", nomeArquivo).Replace("\\", "/");

                    await _userManager.UpdateAsync(usuario);
                }

                TempData["RegistroSuccess"] = "Conta criada com sucesso!";
                //await _signInManager.SignInAsync(usuario, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            TempData["RegistroError"] = "Ocorreu um erro ao criar sua conta.";
            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, TranslateIdentityErrors.TranslateErrorMessage(error.Code));
        }

        return View(registro);
    }

    public IActionResult AccessDenied()
    {
        return View();
    }

    public bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
