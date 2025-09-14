using System.ComponentModel.DataAnnotations;

namespace Leiturinha.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }

        //pq é preciso saber qual a avaliação (nota) que o usuário deu para o livro em específico
        [Required]
        public int LivroId { get; set; }
        public Livro Livro { get; set; } = null!;

        [Required]
        [Range(1, 5, ErrorMessage = "A nota deve ser entre 1 e 5.")]
        public int Nota { get; set; }


        //pra saber quem fez a avaliação
        [Required]
        [StringLength(50)]
        public string Usuario { get; set; } = string.Empty;

        public DateTimeOffset DataAvaliacao { get; set; } = DateTimeOffset.Now;
        //DateTimeOffset é melhor que DateTime pq ele armazena o fuso horário
        //DataAvaliacao é a propriedade que vai guardar quando a avaliação foi feita.
        //DateTimeOffset.Now inicializa essa propriedade com a data e hora atual, no momento em que o objeto Avaliacao é criado.
    }
}
