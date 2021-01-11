using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models.Entities
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }
        public string LivroNome { get; set; }
        public decimal LivroPreco { get; set; }
        public string LivroAnoPublicacao { get; set; }
        public string LivroSinopse { get; set; }
        public string LivroEditora { get; set; }
    }
}
