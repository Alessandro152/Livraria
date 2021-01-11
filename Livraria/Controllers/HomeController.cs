using Livraria.Data.Service;
using Microsoft.AspNetCore.Mvc;

namespace Livraria
{
    public class HomeController : Controller
    {
        private readonly BookService _database;

        public HomeController(BookService dataBase)
        {
            _database = dataBase;
        }

        public IActionResult Index()
        {
            dynamic _livro = _database.GetAll();
            return View(_livro);
        }
    }
}