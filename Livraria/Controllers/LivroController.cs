using Microsoft.AspNetCore.Mvc;
using System;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            var logado = TempData["usuarioLogado"];
            TempData.Keep("usuarioLogado");

            if (logado == null || Convert.ToBoolean(logado) == false)
            {
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}