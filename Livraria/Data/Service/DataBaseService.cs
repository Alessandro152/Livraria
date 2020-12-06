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

        public IEnumerable<LivroViewModel> GetAll()
        {
            using (var db = new LivrariaContext())
            {
                var dados = db.Livros.ToArray();
                yield return new LivroViewModel();
            }
            
        }

        public IEnumerable<LivroViewModel> GetAll(string param)
        {
            return;
        }
    }
}
