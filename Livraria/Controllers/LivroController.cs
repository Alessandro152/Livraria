using Livraria.Data.Service;
using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        private readonly BookService _database;

        public LivroController(BookService database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var logado = TempData["usuarioLogado"];
            TempData.Keep("usuarioLogado");

            if (logado == null || Convert.ToBoolean(logado) == false)
            {
                RedirecionarUsuario();
            }

            return View();
        }

        public IActionResult FindBook(string livroNome)
        {
            var result = _database.GetAll(livroNome);

            return View(result);
        }

        public IActionResult CadastrarLivro()
        {
            var logado = TempData["usuarioLogado"];
            TempData.Keep("usuarioLogado");

            if (logado == null || Convert.ToBoolean(logado) == false)
            {
                RedirecionarUsuario();
            }

            return View();
        }

        private void RedirecionarUsuario()
        {
            RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public IActionResult CadastrarLivro(Livro dados)
        {
            var result = _database.GravarLivro(dados);

            if (result)
            {
                return RedirectToAction(nameof(CadastrarLivro));
            }

            return View();
        }
    }
}