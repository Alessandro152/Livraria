using Livraria.Models.Entities;
using Livraria.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

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
                $@"Server={Environment.MachineName}\WOLTERSKLUWER;Database=Livraria.db;Integrated Security=True");
        }

        public DbSet<Livro> Livro { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
