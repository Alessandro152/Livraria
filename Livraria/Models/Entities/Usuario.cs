using System.ComponentModel.DataAnnotations;

namespace Livraria.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEndereco { get; set; }
        public string UsuarioTelefone { get; set; }
        public int LoginId { get; set; }
    }
}
