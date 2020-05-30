using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;


namespace Eosweb.Controllers
{
    public class IdentificadorController : Controller
    {
        public IActionResult Index(){
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;
            }
            
            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            return View(i);
        }


        public ActionResult Crear(string Compuesto, string Formula, string M) {
            Identificador identificador = new Identificador();
            identificador.Compuesto = Compuesto;
            identificador.Formula = Formula;
            identificador.M = convertToDouble(M);

            if(DataIdentificador.Crear(identificador)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Identificador");
        }

        public ActionResult Modificar(int Id, string Compuesto, string Formula, string M) {

            Identificador f = DataIdentificador.Leer(Id);
            Identificador new_f = new Identificador();
            double temporal;
            
            new_f.Id = f.Id;

            if(Compuesto != null) {
                if(Compuesto != f.Compuesto) {
                    new_f.Compuesto = Compuesto;
                }else {
                    new_f.Compuesto = f.Compuesto;
                }

            }else {
                new_f.Compuesto = f.Compuesto;
            }

            if(Formula != null) {
                if(Formula != f.Formula) {
                    new_f.Formula = Formula;
                }else {
                    new_f.Formula = f.Formula;
                }

            }else {
                new_f.Formula = f.Formula;
            }

            if(M != null){
                temporal = convertToDouble(M);
                if(temporal != f.M) {
                    new_f.M = temporal;
                }else {
                    new_f.M = f.M;
                }
            }else {
                new_f.M = f.M;
            }

            if(DataIdentificador.Modificar(new_f)) {
                //wena
            }
            else {
                //pta :(
            }
            
            return RedirectToAction("Index", "Identificador");
        }



        public ActionResult Eliminar(int Id) {

            if(DataIdentificador.Eliminar(Id)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Identificador");
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