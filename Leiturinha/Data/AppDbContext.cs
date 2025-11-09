using Leiturinha.Models;
using Leiturinha.ViewModels;
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

            builder.Entity<Livro>()
                .HasOne(l => l.Genero)
                .WithMany(g => g.Livros) // ← isso é o que faltava!
                .HasForeignKey(l => l.GeneroId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClassificacaoIndicativa>()
                .HasMany(c => c.Livros)
                .WithOne(l => l.ClassificacaoIndicativa)
                .HasForeignKey(l => l.ClassificacaoIndicativaId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Livro>()
                .HasMany(l => l.Imagens)
                .WithOne(i => i.Livro)
                .HasForeignKey(i => i.LivroId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Livro>()
                .HasMany(l => l.Avaliacoes)
                .WithOne(a => a.Livro)
                .HasForeignKey(a => a.LivroId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Livro>()
                .HasMany(l => l.Comentarios)
                .WithOne(c => c.Livro)
                .HasForeignKey(c => c.LivroId)
                .OnDelete(DeleteBehavior.Cascade);


            AppDbSeed.Seed(builder);
        }
    }
}
