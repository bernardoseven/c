using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CapaEntidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Rut { get; set; }
        public String Nombre { get; set; }
        public String ApPaterno { get; set; }
        public String ApMaterno { get; set; }
        public int Fijo { get; set; }
        public int Celular { get; set; }
        public String Email { get; set; }
        public String Especialidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        
    }
}
