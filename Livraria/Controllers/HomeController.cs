using Livraria.Data.Service;
using Livraria.Models.Entities;
using Livraria.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Livraria
{
    public class HomeController : Controller
    {
        private readonly BookService _database;
        private IEnumerable<Livro> _livro;

        public HomeController(BookService dataBase)
        {
            _database = dataBase;
            _livro = new List<Livro>()
            {
                new Livro
                {
                    LivroNome = "Peter Pan",
                    LivroPreco = 29.99M,
                    LivroAnoPublicacao = "1955"
                },

                new Livro
                {
                    LivroNome = "100 dias entre céu e mar",
                    LivroPreco = 49.99M,
                    LivroAnoPublicacao = "1989"
                },

                new Livro
                {
                    LivroNome = "As aventuras do ratinho detetive",
                    LivroPreco = 49.99M,
                    LivroAnoPublicacao = "1989"
                },

                new Livro
                {
                    LivroNome = "A cartomante",
                    LivroPreco = 49.99M,
                    LivroAnoPublicacao = "1989"
                }
            };
        }

        public IActionResult Index()
        {
           // _livro = _database.GetAll();
            return View(_livro);
        }
    }
}