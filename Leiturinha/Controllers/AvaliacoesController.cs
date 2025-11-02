using Microsoft.AspNetCore.Mvc;
using Leiturinha.Data;
using Leiturinha.Models;
using Microsoft.AspNetCore.Identity;

public class AvaliacoesController : Controller
{
    private readonly AppDbContext _db;
    private readonly UserManager<Usuario> _userManager;

    public AvaliacoesController(AppDbContext db, UserManager<Usuario> userManager)
    {
        _db = db;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> Avaliar([FromBody] AvaliacaoDTO dto)
    {
        var usuarioId = _userManager.GetUserId(User);
        if (usuarioId == null)
        {
            return Unauthorized(); // retorna 401
        }

        var jaAvaliou = _db.Avaliacoes.Any(a => a.LivroId == dto.LivroId && a.UsuarioId == usuarioId);
        if (!jaAvaliou)
        {
            var avaliacao = new Avaliacao
            {
                LivroId = dto.LivroId,
                UsuarioId = usuarioId,
                Nota = dto.Nota,
                DataAvaliacao = DateTimeOffset.Now
            };

            _db.Avaliacoes.Add(avaliacao);
            await _db.SaveChangesAsync();
        }

        return Ok();
    }

    public class AvaliacaoDTO
    {
        public int LivroId { get; set; }
        public int Nota { get; set; }
    }

}
