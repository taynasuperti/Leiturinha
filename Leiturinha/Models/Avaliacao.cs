using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leiturinha.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }

        [Required]
        public int LivroId { get; set; }
        public Livro Livro { get; set; } = null!;

        [Required]
        [ForeignKey("UsuarioId")]
        public string UsuarioId { get; set; } = string.Empty;
        public Usuario Usuario { get; set; } = null!;

        [Required]
        [Range(1, 5, ErrorMessage = "A nota deve ser entre 1 e 5.")]
        public int Nota { get; set; }

        public DateTimeOffset DataAvaliacao { get; set; } = DateTimeOffset.Now;
    }
}
