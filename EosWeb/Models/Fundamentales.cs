using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eosweb.Models
{
    public class Fundamentales
    {
        public int Id {get; set;}
        public Identificador i {get; set;}
        public double Tc_K {get; set;}
        public double Pc_bar {get; set;}
        public double Zc {get; set;}
        public double W {get; set;}
    }
}