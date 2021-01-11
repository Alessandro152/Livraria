using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models.ViewModels
{
    public class EditoraViewModel
    {
        [Key]
        public int EditoraId { get; set; }
        public string EditoraNome { get; set; }
    }
}
