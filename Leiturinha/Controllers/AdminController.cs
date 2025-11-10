using Leiturinha.Data;
using Leiturinha.Models;
using Leiturinha.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Leiturinha.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly AppDbContext _db;
        private readonly UserManager<Usuario> _userManager;

        public AdminController(
            ILogger<AdminController> logger,
            AppDbContext db,
            UserManager<Usuario> userManager
        )
        {
            _logger = logger;
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult Usuarios()
        {
            var usuarios = _userManager.Users
                .Where(u => u.EmailConfirmed) // ou outro critério que você use para "logado"
                .Select(u => new UsuarioVM
                {
                    Nome = u.Nome,
                    Email = u.Email,
                    UserName = u.UserName,
                    DataCadastro = u.DataCadastro
                }).ToList();

            return View(usuarios);
        }
    }
}
