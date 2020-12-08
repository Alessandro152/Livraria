using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models.ViewModels
{
    public class LivroViewModel
    {
        public int LivroId { get; set; }
        public string LivroNome { get; set; }
        public decimal LivroPreco { get; set; }
        public string LivroAnoPublicacao { get; set; }
    }
}
