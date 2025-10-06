
using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Livro
    {
        //adicionando propriedades
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty; //para começar como nula

        [Required]
        [StringLength(150)]
        public string Autor { get; set; } = string.Empty; //para começar como nula

        [Required]
        [StringLength(800)]
        public string Descricao { get; set; } = string.Empty;

        [Required]
        public string Capa { get; set; } = string.Empty;

        public bool Destaque { get; set; } = false;

        //montando o relacionamento entre as tabelas
        [Required]
        public int GeneroId { get; set; }
        public Genero Genero { get; set; } = null!;

        [Required]
        public int ClassificacaoIndicativaId { get; set; }
        public ClassificacaoIndicativa ClassificacaoIndicativa { get; set; } = null!;
        public ICollection<ImagemLivro> Imagens { get; set; } = new List<ImagemLivro>();
        public ICollection<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
