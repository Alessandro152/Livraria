using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models.Entities
{
    public class UsuarioCadastro
    {
        [Key]
        public int UsuarioCadastroId { get; set; }
        public Login Login { get; set; }
        public Usuario Usuario { get; set; }
    }
}
