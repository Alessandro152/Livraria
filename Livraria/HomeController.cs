using Livraria.Data.Service;
using Livraria.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Livraria
{
    public class HomeController : Controller
    {
        private readonly DataBaseService _database;
        
        public HomeController(DataBaseService dataBase)
        {
            _database = dataBase;
        }

        public IActionResult Index()
        {
            var livros = _database.GetAll();
            return View(livros);
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}