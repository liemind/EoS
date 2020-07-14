using System;

namespace Eosweb.Models
{
    public class Log
    {
        public int id {get; set;}
        public DateTime fecha {get; set;}
        public Usuario autor {get; set;}
        public string accion {get; set;}
    }
}