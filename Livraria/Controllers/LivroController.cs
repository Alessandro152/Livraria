using Livraria.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index(Login usuarioLogado)
        {
            if (!usuarioLogado.UsuarioAutenticado)
            {
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}