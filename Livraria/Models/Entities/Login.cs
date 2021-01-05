using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Livraria.Models.Entities
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
    }
}
