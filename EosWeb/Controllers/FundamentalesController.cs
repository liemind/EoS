using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;

namespace Eosweb.Controllers
{
    public class FundamentalesController : Controller
    {
        public IActionResult Index(){
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


        public ActionResult Crear(int Identificador, Fundamentales f) {
            f.Id = Identificador;

            if(DataFundamentales.Crear(f)) {
                //wena
            }
            else {
                //pta :(
            }
            return RedirectToAction("Index", "Fundamentales");
        }
        
        public ActionResult Modificar(int Id, string Tc_K, string Pc_bar, string Zc, string W, int newId) {

            /*if(DataFundamentales.Modificar(f)) {
                //wena
            }
            else {
                //pta :(
            }*/
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
            String[] strlist = s.Split(',');
            final_s = strlist[0]+"."+strlist[1];
            return Convert.ToDouble(final_s);

        }


    }
}