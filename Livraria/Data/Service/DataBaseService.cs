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

        public IEnumerable<Usuario> GetAll()
        {
            using (var db = new LivrariaContext())
            {
                return db.Usuario.ToList();
            }
        }

        internal bool GetUser(string user, string password)
        {
            using (var db = new LivrariaContext())
            {
                try
                {
                    return db.Login.Where(x => x.Email == user && x.Password == password).Any();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    db.Dispose();
                }
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
