namespace Eosweb.Models
{
    public class Usuario
    {
        public int Id {get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Tipo{get; set;}
        public string Estado { get; set; }
    }
}