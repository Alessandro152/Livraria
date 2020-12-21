using Livraria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Data.Service
{
    public class DataBaseService
    {
        public void Save()
        {
            return;
        }

        public void Delete()
        {
            return;
        }

        public IEnumerable<Livro> GetAll()
        {
            using (var db = new LivrariaContext())
            {
                return db.Livro.ToList();
            }
        }

        public IEnumerable<Livro> GetAll(string livroNome)
        {
            using (var db = new LivrariaContext())
            {
                return db.Livro.Where(x => EF.Functions.Like(x.LivroNome, livroNome)).ToArray();
            }
        }
    }
}
