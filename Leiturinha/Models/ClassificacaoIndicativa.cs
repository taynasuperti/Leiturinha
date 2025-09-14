using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class ClassificacaoIndicativa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FaixaEtaria { get; set; } = string.Empty; //estou usando string pq não vou exibir somente o número

        public ICollection<Livro> Livros { get; set; } = new List<Livro>(); // propriedade de navegação (já que uma classificação indicativa pode estar associada a vários livros )
    }
}
