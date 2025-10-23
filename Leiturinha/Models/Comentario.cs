using Leiturinha.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Leiturinha.Models;

public class Comentario
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Livro")]
    [Required(ErrorMessage = "O Livro é obrigatória")]
    public int LivroId { get; set; }
    [ForeignKey("LivroId")]
    [Display(Name = "Livro")]
    public Livro Livro { get; set; }

    [Display(Name = "Usuario")]
    [Required(ErrorMessage = "O Usuario é obrigatório")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    [Display(Name = "Usuario")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data do Comentário")]
    [Required(ErrorMessage = "A Data é obrigatória")]
    public DateTime DataComentario { get; set; }

    [StringLength(300)]
    [Required(ErrorMessage = "O Texto é obrigatório")]
    public string TextoComentario { get; set; }
}