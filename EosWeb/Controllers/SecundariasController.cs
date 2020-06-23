using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;

namespace Eosweb.Controllers
{
    public class SecundariasController : Controller
    {
        public IActionResult Index(){
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
            
            List<Secundarias> f = DataSecundarias.LeerTodo();
                if (f == null) {
                    f = new List<Secundarias>();
                }

                List<Identificador> i = DataIdentificador.LeerTodo();
                if (i == null) {
                    i = new List<Identificador>();
                }
                else {
                    List<Identificador> final_i = new List<Identificador>();
                    foreach (Secundarias var in f) {
                        int remove = search(i,var.i);
                        if(remove != -1) {
                            i.RemoveAt(remove);
                        }
                    }
                }

                ViewData["Identificadores"] = i;
                return View(f);
        }


        public ActionResult Crear(int Identificador, string A, string B, string C, int Tmin_k, int Tmax_k) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);

                Secundarias f = new Secundarias();
                f.Id = Identificador;
                f.A = convertToDouble(A);
                f.B = convertToDouble(B);
                f.C = convertToDouble(C);
                f.Tmin_k = Tmin_k;

                if(DataSecundarias.Crear(f)) {
                    TempData["Notificacion"] = "La operación fue realizada correctamente.";
                    // INICIO LOG
                    Usuario u = DataUsuario.LeerUno(RutSesion);
                    HomeController.crearLog(u, "Usuario "+u.Nombre+" creó un dato secundario.");
                    // FIN LOG
                }
                else {
                    //pta :(
                    TempData["Notificacion"] = "La operación no pudo ser realizada. Inténtelo nuevamente o contacte al administrador.";
                }
            }
            return RedirectToAction("Index", "Secundarias");
            
        }
        
        public ActionResult Modificar(int Id, string A, string B, string C, int Tmin_k, int Tmax_k, int newId) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //Content
                Secundarias f = DataSecundarias.Leer(Id);
                Secundarias new_f = new Secundarias();
                double temporal;
                if(newId != 0) {
                    new_f.Id = newId;
                }else {
                    new_f.Id = f.Id;
                }

                if(A != null) {
                    temporal = convertToDouble(A);
                    if(temporal != f.A) {
                        new_f.A = temporal;
                    }else {
                        new_f.A = f.A;
                    }
                }else {
                    new_f.A = f.A;
                }

                if(B != null) {
                    temporal = convertToDouble(B);
                    if(temporal != f.B) {
                        new_f.B = temporal;
                    }else {
                        new_f.B = f.B;
                    }
                }else {
                    new_f.B = f.B;
                }

                if(C != null){
                    temporal = convertToDouble(C);
                    if(temporal != f.C) {
                        new_f.C = temporal;
                    }else {
                        new_f.C = f.C;
                    }
                }else {
                    new_f.C = f.C;
                }

                if(Tmin_k != 0) {
                    if(Tmin_k != f.Tmin_k) {
                        new_f.Tmin_k = Tmin_k;
                    }else {
                        new_f.Tmin_k = f.Tmin_k;
                    }
                }else {
                    new_f.Tmin_k = f.Tmin_k;
                }

                if(Tmax_k != 0) {
                    if(Tmax_k != f.Tmin_k) {
                        new_f.Tmax_k = Tmax_k;
                    }else {
                        new_f.Tmin_k = f.Tmax_k;
                    }
                }else {
                    new_f.Tmin_k = f.Tmax_k;
                }

                if(DataSecundarias.Modificar(new_f)) {
                    TempData["Notificacion"] = "La operación fue realizada correctamente.";
                    // INICIO LOG
                    Usuario u = DataUsuario.LeerUno(RutSesion);
                    HomeController.crearLog(u, "Usuario "+u.Nombre+" modificó un dato secundario.");
                    // FIN LOG
                }
                else {
                    //pta :(
                    TempData["Notificacion"] = "La operación no pudo ser realizada. Inténtelo nuevamente o contacte al administrador.";
                }
                
            }
            return RedirectToAction("Index", "Secundarias");
        }

        public ActionResult Eliminar(int Id) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //Content
                if(DataSecundarias.Eliminar(Id)) {
                    TempData["Notificacion"] = "La operación fue realizada correctamente.";
                    // INICIO LOG
                    Usuario u = DataUsuario.LeerUno(RutSesion);
                    HomeController.crearLog(u, "Usuario "+u.Nombre+" eliminó un dato secundario.");
                    // FIN LOG
                }
                else {
                    //pta :(
                    TempData["Notificacion"] = "La operación no pudo ser realizada. Inténtelo nuevamente o contacte al administrador.";
                }
            }
            return RedirectToAction("Index", "Secundarias");
        }

        public ActionResult CrearIdentificador(string Compuesto, string Formula, string Masa) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //Content
                Identificador identificador = new Identificador();
                identificador.Compuesto = Compuesto;
                identificador.Formula = Formula;
                identificador.M = convertToDouble(Masa);

                if(DataIdentificador.Crear(identificador)) {
                    TempData["Notificacion"] = "La operación fue realizada correctamente.";
                    // INICIO LOG
                    Usuario u = DataUsuario.LeerUno(RutSesion);
                    HomeController.crearLog(u, "Usuario "+u.Nombre+" creó un identificador.");
                    // FIN LOG
                }
                else {
                    //pta :(
                    TempData["Notificacion"] = "La operación no pudo ser realizada. Inténtelo nuevamente o contacte al administrador.";
                }
            }
            return RedirectToAction("Index", "Secundarias");
        }

        public int search(List<Identificador> list, Identificador value) {
            int i = 0;
            foreach (Identificador id in list){
                if(id.Compuesto == value.Compuesto) {
                //lo encontró
                    return i;
                }
                i++;
            }
            return -1;
        }

        public double convertToDouble(String s) {
            string final_s;
            String[] strlist = s.Split('.');
            if(strlist.Length > 1) {
                final_s = strlist[0]+","+strlist[1];
            }
            else {
                final_s = s;
            }
            
            return Convert.ToDouble(final_s);
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