using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;

namespace Eosweb.Controllers
{
    public class CorrelacionesController : Controller
    {
        // idCompuesto : Compuesto actual seleccionado
        // T : Temperatura en presion de saturacion
        // TEn : Temperatura en entalpia de evaporacion
        // Ps : Presion de Saturacion
        // Te : Temperatura de ebullicion
        // Tne : Temperatura normal de ebullicion
        public IActionResult Index(){
            Identificador iden = new Identificador();

            if (TempData.ContainsKey("idCompuesto")) {
                ViewBag.idCompuesto = TempData["idCompuesto"];
                iden = DataIdentificador.Leer(ViewBag.idCompuesto);
            }
            if (TempData.ContainsKey("Compuesto")) ViewBag.Compuesto = TempData["Compuesto"];
            if (TempData.ContainsKey("Formula")) ViewBag.Formula = TempData["Formula"];
            if (TempData.ContainsKey("M")) ViewBag.M = TempData["M"];

            if (TempData.ContainsKey("T")) ViewBag.T = TempData["T"];
            if (TempData.ContainsKey("TEn")) ViewBag.TEn = TempData["Ten"];
            if (TempData.ContainsKey("Ps")) ViewBag.Ps = TempData["Ps"];
            
            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            else {
                if (TempData.ContainsKey("idCompuesto")) {
                    int remove = search(i, iden);
                    if(remove != -1) {
                            i.RemoveAt(remove);
                    }

                    Secundarias s = DataSecundarias.Leer(iden.Id);
                    ViewBag.A = s.A;
                    ViewBag.B = s.B;
                    ViewBag.C = s.C;
                    ViewBag.Tmax_k = s.Tmax_k;
                    ViewBag.Tmin_k = s.Tmin_k;

                    Fundamentales f = DataFundamentales.Leer(iden.Id);
                    ViewBag.Tc_K = f.Tc_K;
                    ViewBag.Pc_bar = f.Tc_K;
                    ViewBag.Zc = f.Zc;
                    ViewBag.W = f.W;

                }
            }

            return View(i);
        }

        public ActionResult SeleccionarCompuesto(int Id) {
            TempData["idCompuesto"] = Id;
            Identificador i = DataIdentificador.Leer(Id);
            TempData["Compuesto"] = i.Compuesto;
            TempData["Formula"] = i.Formula;
            TempData["M"] = i.M;

            TempData.Remove("T");
            TempData.Remove("TEn");

            return RedirectToAction("Index", "Correlaciones");
        }

        public ActionResult SeleccionarTemperatura(int T, int IdCompuesto) {
            TempData["idCompuesto"] = IdCompuesto;
            Fundamentales f = DataFundamentales.Leer(IdCompuesto);
            Secundarias s = DataSecundarias.Leer(IdCompuesto);

            if(T < s.Tmin_k || T > f.Tc_K) {
                //no hace na
            }
            else {
                //si hace algo
                TempData["T"] = T;
                TempData["Ps"] = Math.Exp(s.A - ((s.B)/(T + s.C)));
            }

            return RedirectToAction("Index", "Correlaciones");
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