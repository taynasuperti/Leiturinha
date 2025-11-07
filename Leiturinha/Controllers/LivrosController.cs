using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Leiturinha.Data;
using Leiturinha.Models;

namespace Leiturinha.Controllers
{
    public class LivrosController : Controller
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Livros
                .Include(l => l.ClassificacaoIndicativa)
                .Include(l => l.Genero);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var livro = await _context.Livros
                .Include(l => l.ClassificacaoIndicativa)
                .Include(l => l.Genero)
                .Include(l => l.Imagens)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (livro == null) return NotFound();

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            ViewData["ClassificacaoIndicativaId"] = new SelectList(_context.Classificacoes, "Id", "FaixaEtaria");
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nome");
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Autor,Descricao,Capa,Destaque,GeneroId,ClassificacaoIndicativaId")] Livro livro, IFormFile ImagemUpload)
        {
            if (ModelState.IsValid)
            {
                if (ImagemUpload != null && ImagemUpload.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(ImagemUpload.FileName);
                    var extension = Path.GetExtension(ImagemUpload.FileName);
                    var newFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/livros", newFileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ImagemUpload.CopyToAsync(stream);
                    }

                    livro.Capa = $"/img/livros/{newFileName}";
                }

                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ClassificacaoIndicativaId"] = new SelectList(_context.Classificacoes, "Id", "FaixaEtaria", livro.ClassificacaoIndicativaId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nome", livro.GeneroId);
            return View(livro);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null) return NotFound();

            ViewData["ClassificacaoIndicativaId"] = new SelectList(_context.Classificacoes, "Id", "FaixaEtaria", livro.ClassificacaoIndicativaId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nome", livro.GeneroId);
            return View(livro);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Autor,Descricao,Capa,Destaque,GeneroId,ClassificacaoIndicativaId")] Livro livro, IFormFile ImagemUpload)
        {
            if (id != livro.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    if (ImagemUpload != null && ImagemUpload.Length > 0)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(ImagemUpload.FileName);
                        var extension = Path.GetExtension(ImagemUpload.FileName);
                        var newFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/livros", newFileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ImagemUpload.CopyToAsync(stream);
                        }

                        livro.Capa = $"/img/livros/{newFileName}";
                    }

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.Id)) return NotFound();
                    else throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["ClassificacaoIndicativaId"] = new SelectList(_context.Classificacoes, "Id", "FaixaEtaria", livro.ClassificacaoIndicativaId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nome", livro.GeneroId);
            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var livro = await _context.Livros
                .Include(l => l.ClassificacaoIndicativa)
                .Include(l => l.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (livro == null) return NotFound();

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.Id == id);
        }
    }
}
