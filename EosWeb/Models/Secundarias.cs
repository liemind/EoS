using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eosweb.Models
{
    public class Secundarias
    {
        public int Id { get; set; }
        public Identificador i {get; set;}
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public int Tmin_k { get; set; }
        public int Tmax_k { get; set; }
        public double Pmin_bar { get; set; }
        public double Pmax_bar { get; set; }
    
    }
}