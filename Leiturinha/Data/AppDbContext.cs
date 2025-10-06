﻿using Leiturinha.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leiturinha.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<ClassificacaoIndicativa> Classificacoes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Renomeando tabelas padrão do Identity para nomes mais amigáveis
            builder.Entity<IdentityUser>().ToTable("Usuario");
            builder.Entity<IdentityRole>().ToTable("Perfil");
            builder.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UsuarioRegras");
            builder.Entity<IdentityUserToken<string>>().ToTable("UsuarioToken");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UsuarioLogin");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("PerfilRegras");

            // Dados iniciais
            AppDbSeed.Seed(builder);
        }
    }
}
