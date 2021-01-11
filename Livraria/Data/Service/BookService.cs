using Livraria.Models.Entities;
using Livraria.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Data.Service
{
    public class BookService
    {
        public bool GravarLivro(Livro dados)
        {
            using (var db = new LivrariaContext())
            {
                try
                {
                    db.Livros.Add(dados);
                    db.SaveChanges();
                    return true;
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

        public void Delete()
        {
            return;
        }

        public IEnumerable<Livro> GetAll()
        {
            using (var db = new LivrariaContext())
            {
                try
                {
                    return db.Livros.ToList();
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
                try
                {
                    return db.Livros.Where(x => EF.Functions.Like(x.LivroNome, livroNome)).ToArray();
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
    }
}
