using System.ComponentModel.DataAnnotations;

namespace Leiturinha.ViewModels
{
    public class AvaliacaoRequest
    {
        [Required]
        public int LivroId { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "A nota deve ser entre 1 e 5.")]
        public double Nota { get; set; }
    }
}
