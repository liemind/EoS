using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;

namespace Eosweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Perfil() {
            //ver si inicio sesion

            //cargar el grupo actual
            //cargar grupos anteriores
            return View();
        }

        /***************
        * Relacionado a perfil
        ***************/

        public ActionResult CambiarPass(string anterior, string nuevo, int id) {
            return RedirectToAction("Perfil", "Home");
        }

        public ActionResult UnirseAGrupo(string llave, int id) {
            return RedirectToAction("Perfil", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
