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
        // V: Volumen del liquido saturado

        public IActionResult Index(){
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];
            Identificador iden = new Identificador();

            if (TempData.ContainsKey("idCompuesto")) {
                ViewBag.idCompuesto = TempData["idCompuesto"];
                iden = DataIdentificador.Leer(ViewBag.idCompuesto);
            }
            if (TempData.ContainsKey("Compuesto")) ViewBag.Compuesto = TempData["Compuesto"];
            if (TempData.ContainsKey("Formula")) ViewBag.Formula = TempData["Formula"];
            if (TempData.ContainsKey("M")) ViewBag.M = TempData["M"];

            
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

            return RedirectToAction("Index", "Correlaciones");
        }

        public ActionResult SeleccionarTemperatura(int T, int IdCompuesto, string Sv, string V, string T3) {
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
                if(Sv != null) {
                    TempData["Sv"] = convertToDouble(Sv);
                }

                //Racket
                if(T3 != null) {
                    TempData["T3"] = convertToDouble(T3);
                }
                if(V != null) {
                    TempData["V"] = convertToDouble(V);
                }

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

        public ActionResult TemperaturaRiedel(int T2, int IdCompuesto, int T, string Ps, string Te, string Tne, string R, string En, string Snv, string V, string T3) {
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
                TempData["T2"] = T2;

                //Presion de Saturacion
                if(Ps != null) {
                    TempData["Ps"] = convertToDouble(Ps);
                }
            
                //Temperatura de ebullición
                if(Te != null) {
                    TempData["Te"] = convertToDouble(Te);
                }

                //Temperatura normal de ebullición
                if(Tne != null) {
                    TempData["Tne"] = convertToDouble(Tne);
                }

                //Riedel
                //Entalpia normal de ebullicion
                if(En != null) {
                    TempData["En"] = convertToDouble(En);
                }
                if(R != null) {
                    TempData["R"] = convertToDouble(R);
                }

                //Entalpia
                double e1= ((1-T2)/f.Tc_K);
                double e2= ((1-convertToDouble(Tne))/f.Tc_K);
                double e3= Math.Pow((e1/e2),0.38);
                double e4 = convertToDouble(En);
                double E = e4 * e3;
                TempData["E"] = E;

                //Entropia normal
                if(Snv != null) {
                    TempData["Snv"] = convertToDouble(Snv);
                }

                //Entropia vaporisacion
                double Sv = E / T2;
                TempData["Sv"] = Sv;

                //Racket
                if(T3 != null) {
                    TempData["T3"] = convertToDouble(T3);
                }
                if(V != null) {
                    TempData["V"] = convertToDouble(V);
                }
            }

            return RedirectToAction("Index", "Correlaciones");
        }

        [HttpPost]
        public JsonResult CalcularAntoine(String T, int Id){ 
            double[] valor = new double[3];

            if(Id != 0 && T != null) {
                double t = convertToDouble(T);
                Fundamentales f = DataFundamentales.Leer(Id);
                Secundarias s = DataSecundarias.Leer(Id);

                if(t >= s.Tmax_k && t <= f.Tc_K) {
                    //Presion de Saturacion
                    double Ps = Math.Exp(s.A - ((s.B)/(t + s.C)));
                    valor[0] = Ps;

                    //Temperatura de ebullición
                    double Te = (s.B / (s.A- Math.Log(Ps))) - s.C;
                    valor[1] = Te;

                    //Temperatura normal de ebullición
                    double Tne = (s.B / (s.A- Math.Log(750))) - s.C;
                    valor[2] = Tne;


                }
            }

            return new JsonResult(valor);
        }

        [HttpPost]
        public JsonResult CalcularVolumenC(int Id, int Opcion) {
            double valor = 0;

            double r = 8.314;
            Fundamentales f = DataFundamentales.Leer(Id);
            if (f != null) {
                valor = f.Zc*r*f.Tc_K/f.Pc_bar/Math.Pow(10,5);
                if(Opcion == 2) {
                    valor = valor * 1000;
                }else if (Opcion == 3) {
                    valor = valor * Math.Pow(100,3);
                }
            }
            return new JsonResult(valor);
        }

        [HttpPost]
        public JsonResult CalcularRacket(String T, int Id, String Vc){
            double valor = 0;
            if(Id != 0) {
                Fundamentales f = DataFundamentales.Leer(Id);
                Secundarias s = DataSecundarias.Leer(Id);
                double t = convertToDouble(T);
                double vc = convertToDouble(Vc);

                if(t >= s.Tmax_k && t <= f.Tc_K) {
                    //constantes
                    double a = 0.2857;
                    valor = vc * Math.Pow(Math.Pow(f.Zc,1-(t/f.Tc_K)),a);
                }
            }

            return new JsonResult(valor);
        }

        [HttpPost]
        public JsonResult CalcularRiedell(String P, int Id, int Opcion, String Tne, String T) {
            double[] valor = new double[5];
            
            if(Id != 0 && P != null && T != null) {
                Fundamentales f = DataFundamentales.Leer(Id);
                Secundarias s = DataSecundarias.Leer(Id);
                double p = convertToDouble(P);
                //acá deberia restringir la presion. Pero nope e.e
                double t = convertToDouble(T);

                if(t >= s.Tmax_k && t <= f.Tc_K) {
                    double tne = convertToDouble(Tne);
                    double r;
                    if(Opcion == 1) {
                        r = 8.314;
                    }else {
                        r = 1.987;
                    }
                    valor[0] = r;
                    

                    //Entalpia normal 
                    double En = r * tne * 1.092 * (Math.Log(f.Pc_bar)- 1.013)/ (0.93-tne/f.Tc_K);
                    valor[1] = En;


                    //Entalpia
                    double E = En * Math.Pow((1-t/f.Tc_K)/(1-tne/f.Tc_K),(19/50));
                    valor[2] = E;

                    //Entropia normal
                    double Sn = En/tne;
                    valor[3] = Sn;

                    //Entropia vaporisacion
                    double Sv = E / t;
                    valor[4] = Sv;
                }

            }

            return new JsonResult(valor);
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

        //Jsons
        [HttpPost]
        public JsonResult CapacidadCaloricaCPH(String T1, String T2, int Id)
        {
            double valor = 0;
            if(T1 != null && T2 != null && Id != 0) {
                string patron = ".";
                string[] T1_s = T1.Split(patron);
                string[] T2_s = T2.Split(patron);
                string t1 ="", t2 ="";

                double r = 8.314;
                //reformo
                if(T1_s.Length > 1) {
                    t1 = T1_s[0]+","+T1_s[1];  
                }
                else { t1 = T1_s[0]; }

                if(T2_s.Length > 1) {
                    t2 = T2_s[0]+","+T2_s[1];  
                }
                else { t2 = T2_s[0]; }

                Double FinalT1 = Convert.ToDouble(t1);
                Double FinalT2 = Convert.ToDouble(t2);

                Fundamentales f = DataFundamentales.Leer(Id);
                Secundarias s = DataSecundarias.Leer(Id);
                if((FinalT1 >= s.Tmax_k && FinalT1 <= f.Tc_K) && (FinalT2 >= s.Tmax_k && FinalT2 <= f.Tc_K)) {
                    Constantes cons = DataConstantes.Leer(Id);
                    if (cons != null) {
                        valor = r/(FinalT2-FinalT1) * (Convert.ToDouble(cons.A) *(FinalT2-FinalT1)+Convert.ToDouble(cons.B)/2*(Math.Pow(FinalT2, 2) - Math.Pow(FinalT1, 2))+Convert.ToDouble(cons.C)/3*(Math.Pow(FinalT2, 3) - Math.Pow(FinalT1, 3))-Convert.ToDouble(cons.D)*(1/FinalT2-1/FinalT1));
                    } 
                }
            }
            
            return new JsonResult(valor);
        }

        [HttpPost]
        public JsonResult CapacidadCaloricaCPS(String T1, String T2, int Id)
        {
            double valor = 0;
            Constantes cons = DataConstantes.Leer(Id);
            if (cons != null) {
                if(T1 != null && T2 != null && Id != 0) {
                    string patron = ".";
                    string[] T1_s = T1.Split(patron);
                    string[] T2_s = T2.Split(patron);
                    string t1 ="", t2 ="";
                    double r = 8.314;
                    //reformo
                    if(T1_s.Length > 1) {
                        t1 = T1_s[0]+","+T1_s[1];  
                    }
                    else { t1 = T1_s[0]; }

                    if(T2_s.Length > 1) {
                        t2 = T2_s[0]+","+T2_s[1];  
                    }
                    else { t2 = T2_s[0]; }

                    Double FinalT1 = Convert.ToDouble(t1);
                    Double FinalT2 = Convert.ToDouble(t2);

                    Fundamentales f = DataFundamentales.Leer(Id);
                    Secundarias s = DataSecundarias.Leer(Id);
                    if((FinalT1 >= s.Tmax_k && FinalT1 <= f.Tc_K) && (FinalT2 >= s.Tmax_k && FinalT2 <= f.Tc_K)) {
                        valor =r/Math.Log(FinalT2/FinalT1)*(Convert.ToDouble(cons.A)*(Math.Log(FinalT2)-Math.Log(FinalT1))+Convert.ToDouble(cons.B)*(FinalT2-FinalT1)+Convert.ToDouble(cons.C)/2*(Math.Pow(FinalT2, 2)-Math.Pow(FinalT1, 2))-Convert.ToDouble(cons.D)/2*(1/Math.Pow(FinalT2, 2)-1/Math.Pow(FinalT1, 2)));
                    }
                }
            }

            return new JsonResult(valor);
        }

        [HttpPost]
        public JsonResult LeerConstante(int Id)
        {
            Constantes c = DataConstantes.Leer(Id);
            return new JsonResult(c);
        }

        [HttpPost]
        public JsonResult LeerSecundarias(int Id)
        {
            Secundarias s = DataSecundarias.Leer(Id);
            return new JsonResult(s);
        }

    }
    
}