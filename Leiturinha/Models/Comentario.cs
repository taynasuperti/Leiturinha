using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        //pq é preciso saber qual comentário que o usuário deu para o livro em específico
        [Required]
        public int LivroId { get; set; }
        public Livro Livro { get; set; } = null!;

        //pra saber quem fez a avaliação
        [Required]
        [StringLength(50)]
        public string Usuario { get; set; } = string.Empty;

        //pra saber o conteúdo do comentário
        [Required]
        [StringLength(800)]
        public string Conteudo { get; set; } = string.Empty;

        public DateTimeOffset DataComentario { get; set; } = DateTimeOffset.Now; // mesmo esquema da avaliação, esse trecho ajuda a aparecer corretamente data e hora do comentário
    }
}
