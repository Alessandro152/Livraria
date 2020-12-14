using Livraria.Data.Service;
using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class LoginController : Controller
    {
        private Login _login;
        private readonly UserService _services;
        const string ERRO = "deu ruim";

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

            if (!result)
            {
                _login.UsuarioAutenticado = false;
                return View(nameof(Login), _login);
            }

            return RedirectToAction ("Index", "Livro", new Login() {UsuarioAutenticado = _login.UsuarioAutenticado});
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
    }
}