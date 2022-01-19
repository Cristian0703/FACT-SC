using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACT_SC
{
    class Persona
    {
        public string nombre{ get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }

        public Persona() { }

        public Persona(string pNombre, string pApellidos, string pTelefono)
        {
            this.nombre = pNombre;
            this.apellidos = pApellidos;
            this.telefono = pTelefono;

        }
    }
}
