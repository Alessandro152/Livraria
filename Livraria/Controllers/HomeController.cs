﻿using Livraria.Data.Service;
using Livraria.Models.Entities;
using Livraria.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Livraria
{
    public class HomeController : Controller
    {
        private readonly DataBaseService _database;
        private IEnumerable<Livro> _livro;

        public HomeController(DataBaseService dataBase)
        {
            _database = dataBase;
            _livro = new List<Livro>();
        }

        public IActionResult Index()
        {
            _livro = _database.GetAll();
            return View(_livro);
        }
    }
}