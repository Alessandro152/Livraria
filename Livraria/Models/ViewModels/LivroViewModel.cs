
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }
        public string LivroNome { get; set; }
        public decimal LivroPreco { get; set; }
        public string LivroAnoPublicacao { get; set; }
        public string LivroSinopse { get; set; }

        public EditoraViewModel Editora { get; set; }
    }
}
