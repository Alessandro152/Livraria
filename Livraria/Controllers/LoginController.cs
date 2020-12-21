using Livraria.Data.Service;
using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class LoginController : Controller
    {
        private Login _login;
        private readonly UserService _services;

        public LoginController(UserService services)
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
        public IActionResult AutenticarUsuario(Login dados)
        {
            var result = _services.GetUser(dados.Email, dados.Password);

            TempData["usuarioLogado"] = result;

            if (!result)
            {
                _login.UsuarioAutenticado = false;
                return View(nameof(Login), _login);
            }

            return RedirectToAction ("Index", "Livro");
        }

        public IActionResult CadastrarUsuario(UsuarioCadastro dados)
        {
            _services.SalvarCadastroUsuario(dados);
            return View(nameof(Login));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Login dados)
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