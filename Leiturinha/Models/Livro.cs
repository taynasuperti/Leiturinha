using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Livro 
    {
        //adicionando propriedades
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

        //montando o relacionamento entre as tabelas
        [Required]
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        [Required]
        public int ClassificacaoIndicativaId { get; set; }
        public ClassificacaoIndicativa ClassificacaoIndicativa { get; set; }

        public ICollection<ImagemLivro> Imagens { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
