namespace Leiturinha.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }

        public int LivroId { get; set; }
        public Livro Livro { get; set; } = null!;

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public double Nota { get; set; }

        public DateTimeOffset DataAvaliacao { get; set; } = DateTimeOffset.Now;
    }
}
