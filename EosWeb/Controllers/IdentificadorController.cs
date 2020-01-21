using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;

namespace Eosweb.Controllers
{
    public class IdentificadorController : Controller
    {
        public IActionResult Index(){
            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            return View(i);
        }


        public ActionResult Crear(Identificador i) {
            if(DataIdentificador.Crear(i)) {
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
    }
}