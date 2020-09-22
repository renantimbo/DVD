using System.Reflection;
using DVD.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DVD.Context
{
    public class FilmeDbContext : DbContext
    {
        public FilmeDbContext()
        {
        }

        public FilmeDbContext(DbContextOptions<FilmeDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04783\\SQLEXPRESS;Initial Catalog=FilmesDB; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FilmeDbContext).Assembly);

            modelBuilder.Entity<FilmeGenero>().HasOne(q => q.Filme).WithMany(q => q.FilmeGenero).HasForeignKey(q => q.IdGenero);
            modelBuilder.Entity<FilmeGenero>().HasOne(q => q.Genero).WithMany(q => q.FilmeGenero).HasForeignKey(q => q.IdFilme);
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<FilmeGenero> FilmeGenero { get; set; }
    }
}
