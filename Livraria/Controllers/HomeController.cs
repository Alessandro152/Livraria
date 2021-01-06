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

        public HomeController(BookService dataBase)
        {
            _database = dataBase;
        }

        public IActionResult Index()
        {
            var _livro = _database.GetAll();
            return View(_livro);
        }
    }
}