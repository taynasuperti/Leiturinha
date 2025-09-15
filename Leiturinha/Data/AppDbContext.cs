using Leiturinha.Models;

namespace Leiturinha.Data
{
    public class AppDbContext : DbContext //herdando a classe DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Livro> Livros { get; set; } //representa a tabela Livros no banco de dados
        public DbSet<Genero> Generos { get; set; } //representa a tabela Generos no banco de dados
        public DbSet<ClassificacaoIndicativa> Classificacoes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; } //representa a tabela Avaliacoes no banco de dados
        public DbSet<Comentario> Comentarios { get; set; } //representa a tabela Comentarios no banco de dados

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppDbSeed.Seed(modelBuilder); //chamando o método Seed da classe AppDbSeed para popular o banco de dados com dados iniciais
        }
    }
}
