using Livraria.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(MAQ-3077)\WOLTERSKLUWER;Database=Livraria_db;Integrated Security=True");
        }

        public DbSet<Livro> Livros { get; set; }

    }
}
