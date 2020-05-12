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
        // T : Temperatura
        // TEn : Temperatura en entalpia de evaporacion
        // Ps : Presion de Saturacion
        // Te : Temperatura de ebullicion
        // Tne : Temperatura normal de ebullicion
        // En : Entalpia normal
        // E : Entalpia de vaporisacion
        // Snv : Entropia normal de vaporisacion
        // Sv : Entropia de vaporisacion

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
            if (TempData.ContainsKey("Tne")) ViewBag.Tne = TempData["Tne"];
            if (TempData.ContainsKey("Te")) ViewBag.Te = TempData["Te"];
            if (TempData.ContainsKey("Ps")) ViewBag.Ps = TempData["Ps"];

            if (TempData.ContainsKey("En")) ViewBag.En = TempData["En"];
            if (TempData.ContainsKey("R")) ViewBag.R = TempData["R"];

            if (TempData.ContainsKey("T2")) ViewBag.T2 = TempData["T2"];
            if (TempData.ContainsKey("E")) ViewBag.E = TempData["E"];
            if (TempData.ContainsKey("Snv")) ViewBag.Snv = TempData["Snv"];
            if (TempData.ContainsKey("Sv")) ViewBag.Sv = TempData["Sv"];

            
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
            TempData.Remove("Ps");
            TempData.Remove("En");
            TempData.Remove("R");

            return RedirectToAction("Index", "Correlaciones");
        }

        public ActionResult SeleccionarTemperatura(int T, int IdCompuesto) {
            TempData["idCompuesto"] = IdCompuesto;
            Identificador i = DataIdentificador.Leer(IdCompuesto);
            TempData["Compuesto"] = i.Compuesto;
            TempData["Formula"] = i.Formula;
            TempData["M"] = i.M;

            Fundamentales f = DataFundamentales.Leer(IdCompuesto);
            Secundarias s = DataSecundarias.Leer(IdCompuesto);

            if(T < s.Tmax_k || T > f.Tc_K) {
                //no hace na
            }
            else {
                //si hace algo
                TempData["T"] = T;

                //Presion de Saturacion
                double Ps = Math.Exp(s.A - ((s.B)/(T + s.C)));
                TempData["Ps"] = Ps;

                //Temperatura de ebullición
                double Te = (s.B / (s.A- Math.Log(Ps))) - s.C;
                TempData["Te"] = Te;

                //Temperatura normal de ebullición
                //double Tne = (s.B / (s.A- Math.Log(1.01325))) - s.C;
                double Tne = (s.B / (s.A- Math.Log(750))) - s.C;
                TempData["Tne"] = Tne;

                //Riedel

                //Entalpia normal
                double R = 8.3144703523;
                double En = R * Tne * (1.092 * (Math.Log(f.Pc_bar)- 1.013))/ (0.93-Tne/f.Tc_K);
                TempData["En"] = En;
                TempData["R"] = R;

                //Entropia normal de vaporisacion
                double Snv = En/Tne;
                TempData["Snv"] = Snv;
            }

            return RedirectToAction("Index", "Correlaciones");
        }

        public ActionResult TemperaturaRiedel(int T2, int IdCompuesto, int T, string Ps, string Te, string Tne, string R, string En, string Snv) {
            TempData["idCompuesto"] = IdCompuesto;
            Identificador i = DataIdentificador.Leer(IdCompuesto);
            TempData["Compuesto"] = i.Compuesto;
            TempData["Formula"] = i.Formula;
            TempData["M"] = i.M;

            Fundamentales f = DataFundamentales.Leer(IdCompuesto);
            Secundarias s = DataSecundarias.Leer(IdCompuesto);

            if(T2 < s.Tmax_k || T2 > f.Tc_K) {
                //no hace na
            }
            else {
                //si hace algo
                TempData["T"] = T;

                //Presion de Saturacion
                TempData["Ps"] = convertToDouble(Ps);

                //Temperatura de ebullición
                TempData["Te"] = convertToDouble(Te);

                //Temperatura normal de ebullición
                TempData["Tne"] = convertToDouble(Tne);

                //Riedel
                //Entalpia normal de ebullicion
                TempData["En"] = convertToDouble(En);
                TempData["R"] = convertToDouble(R);

                //Entalpia
                double E = convertToDouble(En) * Math.Pow(((1-T2/f.Tc_K)/(1-convertToDouble(Tne)/f.Tc_K)),0.38);
                TempData["E"] = E;

                //Entropia normal
                TempData["Snv"] = convertToDouble(Snv);

                //Entropia vaporisacion
                double Sv = E / T2;
                TempData["Sv"] = Sv;


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