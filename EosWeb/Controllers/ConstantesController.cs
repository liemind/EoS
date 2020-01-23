using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;

namespace Eosweb.Controllers
{
    public class ConstantesController : Controller
    {
        public IActionResult Index(){
            List<Constantes> f = DataConstantes.LeerTodo();
            if (f == null) {
                f = new List<Constantes>();
            }

            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            else {
                List<Identificador> final_i = new List<Identificador>();
                foreach (Constantes var in f) {
                    int remove = search(i,var.i);
                    if(remove != -1) {
                        i.RemoveAt(remove);
                    }
                }
            }

            ViewData["Identificadores"] = i;
            return View(f);
        }


        public ActionResult Crear(int Identificador, string A, string B, string C, string D) {
            Constantes f = new Constantes();
            f.Id = Identificador;
            f.A = convertToDouble(A);
            f.B = convertToDouble(B);
            f.C = convertToDouble(C);
            f.D = convertToDouble(D);

            if(DataConstantes.Crear(f)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Constantes");
        }
        
        public ActionResult Modificar(int Id, string A, string B, string C, string D, int newId) {

            Constantes f = DataConstantes.Leer(Id);
            Constantes new_f = new Constantes();
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

            if(D != null) {
                temporal = convertToDouble(D);
                if(temporal != f.D) {
                    new_f.D = temporal;
                }else {
                    new_f.D = f.D;
                }
            }else {
                new_f.D = f.D;
            }

            if(DataConstantes.Modificar(new_f)) {
                //wena
            }
            else {
                //pta :(
            }
            
            return RedirectToAction("Index", "Constantes");
        }

        public ActionResult Eliminar(int Id) {

            if(DataConstantes.Eliminar(Id)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Constantes");
        }

        public ActionResult CrearIdentificador(string Compuesto, string Formula, string Masa) {
            Identificador identificador = new Identificador();
            identificador.Compuesto = Compuesto;
            identificador.Formula = Formula;
            identificador.M = convertToDouble(Masa);

            if(DataIdentificador.Crear(identificador)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Constantes");
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




    }
}