using Leiturinha.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Livro 
    {
        public int Id { get; set; }

        [Required, StringLength(400)]
        public string Titulo { get; set; }

        [Required, StringLength(150)]
        public string Autor { get; set; }

        [Required, MaxLength(5000)]
        public string Descricao { get; set; }

        [Required]
        public string Capa { get; set; }

        public bool Destaque { get; set; }

        [Required]
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        [Required]
        public int ClassificacaoIndicativaId { get; set; }
        public ClassificacaoIndicativa ClassificacaoIndicativa { get; set; }

        public ICollection<ImagemLivro> Imagens { get; set; } = new List<ImagemLivro>();
        public ICollection<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    }
}
