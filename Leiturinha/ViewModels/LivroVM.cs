namespace Leiturinha.ViewModels;

using Leiturinha.Models;

public class LivroVM
{
    public Livro Livro { get; set; }
    public List<Livro> Semelhantes { get; set; }
    public double MediaEstrelas { get; set; }
}
