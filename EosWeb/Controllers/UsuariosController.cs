using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;


namespace Eosweb.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;
                    
                    List<Usuario> finalUsuarios = DataUsuario.LeerTodo();
                    if (finalUsuarios == null)
                    {
                        finalUsuarios = new List<Usuario>();
                    }

                    return View(finalUsuarios);
            }
            return RedirectToAction("Invitado", "Home");
        }

        public ActionResult Crear(String Rut, String Nombre, String Correo, String Tipo) {
            Usuario usuario = new Usuario();
            usuario.Rut = Rut;
            usuario.CorreoElectronico = Correo;
            usuario.Nombre = Nombre;
            usuario.Tipo = Tipo;


            //Encriptar Pass
            String pass = HomeController.GenerarPass();
            String passE = HomeController.Encriptar(pass);
            usuario = DataUsuario.Crear(usuario, passE);

            //mandar correo
        
            return RedirectToAction("Index", "Usuarios");
        }

        public IActionResult Acciones()
        {
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;

                    return View();
            }
            return RedirectToAction("Invitado", "Home");
        }

        public IActionResult Grupos()
        {
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;

                    return View();
            }
            return RedirectToAction("Invitado", "Home");
        }

        /********
        * SESION
        ********/
        public Boolean Sesion() {
            Boolean exist = string.IsNullOrEmpty(HttpContext.Session.GetString(Global.SessionKeyName));
            if (exist) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}