using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;

namespace Eosweb.Controllers
{
    public class CorrelacionesController : Controller
    {
        public IActionResult Index(){
            List<Identificador> i = DataIdentificador.LeerTodo();
            if (i == null) {
                i = new List<Identificador>();
            }
            return View(i);
        }

    }
    
}