using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGestor
{
    public class Mensaje
    {
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public Contacto Remitente { get; set; }
        public Contacto Para { get; set; }

        public Mensaje() { }
        

        
    }
}
