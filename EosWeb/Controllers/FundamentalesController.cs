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
        public IActionResult Index()
        {
            List<Fundamentales> f = DataFundamentales.LeerTodo();
            if (f == null) {
                f = new List<Fundamentales>();
            }
            return View(f);
        }
    }
}