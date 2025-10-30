using Leiturinha.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leiturinha.Data
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<ClassificacaoIndicativa> Classificacoes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<ImagemLivro> ImagemLivros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Usuario>().ToTable("Usuario");
            builder.Entity<IdentityRole>().ToTable("Perfil");
            builder.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UsuarioRegra");
            builder.Entity<IdentityUserToken<string>>().ToTable("UsuarioToken");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UsuarioLogin");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("PerfilRegra");

            AppDbSeed.Seed(builder);
        }
    }
}
