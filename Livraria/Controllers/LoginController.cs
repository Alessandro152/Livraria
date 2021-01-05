using Livraria.Data.Service;
using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Livraria.Controllers
{
    public class LoginController : Controller
    {
        private Login _login;
        private readonly UserService _services;

        public LoginController(UserService services)
        {
            _services = services;
            _login = new Login();
        }

        public IActionResult Login()
        {
            var logado = TempData["usuarioLogado"];

            if (logado == null || Convert.ToBoolean(logado) == false)
            {
                return View(nameof(Login), _login);
            }

            return View("Livro", "Index");
        }

        [HttpGet]
        public IActionResult AutenticarUsuario(Login dados)
        {
            var result = _services.GetUser(dados.UserMail, dados.UserPassword);

            TempData["usuarioLogado"] = result;

            if (!result)
            {
                return View(nameof(Login), _login);
            }

            return RedirectToAction ("Index", "Livro");
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioCadastro dados)
        {
            _services.SalvarCadastroUsuario(dados);
            return View(nameof(Login));
        }

        
        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        public IActionResult Logout()
        {
            TempData["usuarioLogado"] = false;
            return View("Home", "Index");
        }
    }
}