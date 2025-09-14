using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Livro> Livros { get; set; } = new List<Livro>();  // propriedade de navegação (já que um genero pode estar associado a vários livros )
    }
}
