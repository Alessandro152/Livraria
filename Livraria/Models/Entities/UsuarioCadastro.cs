using System.ComponentModel.DataAnnotations;

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
