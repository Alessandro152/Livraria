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
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }

        public DbSet<Livro> Livros { get; set; }

    }
}
