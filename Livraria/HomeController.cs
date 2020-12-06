using Livraria.Data.Service;
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
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}