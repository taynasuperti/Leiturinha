using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leiturinha.Models
{
    [Table("ImagemLivro")]
    public class ImagemLivro
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Livro")]
        [Required(ErrorMessage = "Por favor, informe o Livro")]
        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public Livro Livro { get; set; } = null!;

        [Required(ErrorMessage = "Por favor, informe a Imagem")]
        [StringLength(200)]
        public string CaminhoImagem { get; set; } = string.Empty; // Ex.: "capas/menino_maluquinho_capa.jpg"

        [Display(Name = "Descrição")]
        [StringLength(100, ErrorMessage = "A descrição deve possuir no máximo 100 caracteres")]
        public string DescricaoFoto { get; set; } = string.Empty; // Ex.: "Capa", "Contracapa", "Página interna"
    }
}
