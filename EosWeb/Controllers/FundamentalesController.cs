using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;


namespace Eosweb.Controllers
{
    public class FundamentalesController : Controller
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
            
            List<Fundamentales> f = DataFundamentales.LeerTodo();
            if (f == null) {
                f = new List<Fundamentales>();
            }

            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            else {
                List<Identificador> final_i = new List<Identificador>();
                foreach (Fundamentales var in f) {
                    int remove = search(i,var.i);
                    if(remove != -1) {
                        i.RemoveAt(remove);
                    }
                }
            }

            ViewData["Identificadores"] = i;
            return View(f);
        }

        public ActionResult Crear(int Identificador, string Tc_K, string Pc_bar, string Zc, string W) {
            Fundamentales f = new Fundamentales();
            f.Id = Identificador;
            f.Tc_K = convertToDouble(Tc_K);
            f.Pc_bar = convertToDouble(Pc_bar);
            f.Zc = convertToDouble(Zc);
            f.W = convertToDouble(W);

            if(DataFundamentales.Crear(f)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Fundamentales");
        }
        
        public ActionResult Modificar(int Id, string Tc_K, string Pc_bar, string Zc, string W, int newId) {

            Fundamentales f = DataFundamentales.Leer(Id);
            Fundamentales new_f = new Fundamentales();
            double temporal;
            if(newId != 0) {
                new_f.Id = newId;
            }else {
                new_f.Id = f.Id;
            }

            if(Tc_K != null) {
                temporal = convertToDouble(Tc_K);
                if(temporal != f.Tc_K) {
                    new_f.Tc_K = temporal;
                }else {
                    new_f.Tc_K = f.Tc_K;
                }

            }else {
                new_f.Tc_K = f.Tc_K;
            }

            if(Pc_bar != null) {
                temporal = convertToDouble(Pc_bar);
                if(temporal != f.Pc_bar) {
                    new_f.Pc_bar = temporal;
                }else {
                    new_f.Pc_bar = f.Pc_bar;
                }
            }else {
                new_f.Pc_bar = f.Pc_bar;
            }

            if(Zc != null){
                temporal = convertToDouble(Zc);
                if(temporal != f.Zc) {
                    new_f.Zc = temporal;
                }else {
                    new_f.Zc = f.Zc;
                }
            }else {
                new_f.Zc = f.Zc;
            }

            if(W != null) {
                temporal = convertToDouble(W);
                if(temporal != f.W) {
                    new_f.W = temporal;
                }else {
                    new_f.W = f.W;
                }
            }else {
                new_f.W = f.W;
            }

            if(DataFundamentales.Modificar(new_f)) {
                //wena
            }
            else {
                //pta :(
            }
            
            return RedirectToAction("Index", "Fundamentales");
        }

        public ActionResult Eliminar(int Id) {

            if(DataFundamentales.Eliminar(Id)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Fundamentales");
        }

        public ActionResult CrearIdentificador(string Compuesto, string Formula, string M) {
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
            return RedirectToAction("Index", "Fundamentales");
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