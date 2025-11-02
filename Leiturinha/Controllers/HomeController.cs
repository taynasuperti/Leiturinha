using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Leiturinha.Models;
using Leiturinha.Data;
using Microsoft.EntityFrameworkCore;
using Leiturinha.ViewModels;

namespace Leiturinha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        // Página inicial com todos os livros e destaques no topo
        public IActionResult Index()
        {
            var livros = _db.Livros
                .Include(l => l.Avaliacoes)
                .Include(l => l.Genero)
                .Include(l => l.ClassificacaoIndicativa)
                .ToList();

            var livrosComMedia = livros.Select(l => new LivroVM
            {
                Livro = l,
                MediaEstrelas = l.Avaliacoes.Any() ? l.Avaliacoes.Average(a => a.Nota) : 0
            }).ToList();

            var destaques = livrosComMedia
                .Where(vm => vm.Livro.Destaque ||
                             (vm.Livro.Avaliacoes.Count >= 3 && vm.MediaEstrelas >= 4.0))
                .OrderByDescending(vm => vm.MediaEstrelas)
                .ToList();

            var homeVM = new HomeVM
            {
                Destaques = destaques,
                Todos = livrosComMedia
            };

            return View(homeVM);
        }

        // Página de detalhes de um livro
        public IActionResult Livro(int id)
        {
            var livro = _db.Livros
                .Include(l => l.Genero)
                .Include(l => l.ClassificacaoIndicativa)
                .Include(l => l.Avaliacoes)
                .Include(l => l.Imagens)
                .SingleOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return NotFound();
            }

            // Carrega os comentários com os dados do usuário
            var comentarios = _db.Comentarios
                .Include(c => c.Usuario)
                .Where(c => c.LivroId == id)
                .OrderByDescending(c => c.DataComentario)
                .ToList();

            var semelhantes = _db.Livros
                .Where(l => l.Id != id && l.GeneroId == livro.GeneroId)
                .Include(l => l.Genero)
                .Include(l => l.ClassificacaoIndicativa)
                .Take(4)
                .ToList();

            var mediaEstrelas = livro.Avaliacoes.Any() ? livro.Avaliacoes.Average(a => a.Nota) : 0;

            var livroVM = new LivroVM
            {
                Livro = livro,
                Comentarios = comentarios,
                Semelhantes = semelhantes,
                MediaEstrelas = mediaEstrelas
            };
            ViewBag.ExibirMedia = User.IsInRole("Admin");
            return View(livroVM);
        }

        public IActionResult Livros()
        {
            var livros = _db.Livros
                .Include(l => l.Genero)
                .Include(l => l.ClassificacaoIndicativa)
                .Include(l => l.Imagens)
                .Include(l => l.Avaliacoes)
                .ToList();

            var livrosComMedia = livros.Select(l => new LivroVM
            {
                Livro = l,
                MediaEstrelas = l.Avaliacoes.Any() ? l.Avaliacoes.Average(a => a.Nota) : 0
            }).ToList();

            return View(livrosComMedia);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
