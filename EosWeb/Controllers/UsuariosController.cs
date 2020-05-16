using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;

namespace Eosweb.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public ActionResult Crear(String Rut, String Nombre, String Correo, String Tipo) {
            
            
            return RedirectToAction("Index", "Usuarios");
        }

        public IActionResult Acciones()
        {
            return View();
        }

        public IActionResult Grupos()
        {
            return View();
        }

        
    }
}