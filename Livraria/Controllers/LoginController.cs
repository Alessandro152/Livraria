using Livraria.Data.Service;
using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class LoginController : Controller
    {
        private Login _login;
        private readonly DataBaseService _services;
        const string ERRO = "deu ruim";

        public LoginController(DataBaseService services)
        {
            _services = services;
            _login = new Login()
            {
                UsuarioAutenticado = true
            };
        }

        public IActionResult Login()
        {
            return View(_login);
        }

        [HttpGet]
        public IActionResult AutenticarUsuario(string user, string password)
        {
            var result = _services.GetUser(user, password);

            if (!result)
            {
                _login.UsuarioAutenticado = false;
            }

            return View("Login",_login);
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(string user, string password)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecuperarSenha(string user)
        {
            return View();
        }
    }
}