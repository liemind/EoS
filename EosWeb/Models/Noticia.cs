using System;

namespace Eosweb.Models
{
    public class Noticia
    {
        public int id {get; set;}
        public string titulo {get; set;}
        public string cuerpo {get; set;}
        public DateTime fecha {get; set;}
        public Usuario autor {get; set;} 
    }
}