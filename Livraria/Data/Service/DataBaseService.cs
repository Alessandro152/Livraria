using Livraria.Models.Entities;
using Livraria.Models.ViewModels;
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
                var dados = db.Usuario.ToList();

                return dados;
            }
            
        }

        //public IEnumerable<LivroViewModel> GetAll(string param)
        //{
        //    return;
        //}
    }
}
