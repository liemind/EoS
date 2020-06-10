using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;

namespace Eosweb.Controllers
{
    public class NoticiaController : Controller
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
            }
            List<Noticia> n = new List<Noticia>();
            n = DataNoticia.LeerTodo();

            if (n == null) {
                n = new List<Noticia>();
            }

            return View(n);
        }

        //Ver noticia
        public IActionResult Noticia(int Id)
        {
            Noticia n = DataNoticia.LeerUno(Id);
            return View(n);
        }

        //Crear Noticia
        public ActionResult Crear(string Titulo, string Cuerpo)
        {
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                Noticia noticia = new Noticia();
                noticia.titulo = Titulo;
                noticia.cuerpo = Cuerpo;
                noticia.autor = DataUsuario.LeerUno(Rut);
                noticia.fecha = DateTime.Now;

                //crear noticia
                if(DataNoticia.Crear(noticia)) {
                    //se creo
                }

                return RedirectToAction("Index", "Noticia");
            }
            return RedirectToAction("Invitado", "Home");
        }
        

        //Editar noticia

        //Eliminar noticia

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