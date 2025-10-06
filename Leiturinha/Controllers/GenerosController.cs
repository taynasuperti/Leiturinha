using System.Threading.Tasks;
using Leiturinha.Data;
using Leiturinha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Leiturinha.Controllers;

public class GenerosController : Controller
{
    private readonly ILogger<GenerosController> _logger;
    private readonly AppDbContext _db;

    public GenerosController(ILogger<GenerosController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    // Lista todos os gêneros
    public IActionResult Index()
    {
        List<Genero> generos = _db.Generos.ToList();
        return View(generos);
    }

    // Exibe formulário de criação
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // Cria novo gênero
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Genero genero)
    {
        if (ModelState.IsValid)
        {
            _db.Generos.Add(genero);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Gênero cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        return View(genero);
    }

    // Exibe detalhes de um gênero
    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();

        var genero = await _db.Generos.FirstOrDefaultAsync(g => g.Id == id);
        if (genero == null)
            return NotFound();

        return View(genero);
    }

    // Exibe formulário de edição
    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var genero = await _db.Generos.FirstOrDefaultAsync(g => g.Id == id);
        if (genero == null)
            return NotFound();

        return View(genero);
    }

    // Edita gênero
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Genero genero)
    {
        if (id != genero.Id)
            return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _db.Generos.Update(genero);
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            TempData["Success"] = "Gênero alterado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        return View(genero);
    }

    // Exibe confirmação de exclusão
    [HttpGet]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
            return NotFound();

        var genero = await _db.Generos.FirstOrDefaultAsync(g => g.Id == id);
        if (genero == null)
            return NotFound();

        return View(genero);
    }

    // Exclui gênero
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var genero = await _db.Generos.FindAsync(id);
        if (genero != null)
        {
            _db.Generos.Remove(genero);
            await _db.SaveChangesAsync();
        }

        TempData["Success"] = "Gênero excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
