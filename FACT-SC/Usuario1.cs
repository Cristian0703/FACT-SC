using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACT_SC
{
    class Usuario1
    {
        public string email { get; set; }
        public string contraseña { get; set; }

        public int rol { get; set; }
        public int personasID { get; set; }

        public Usuario1() { }

        public Usuario1(string pEmail, string pContraseña, int pRol, int pPersonasID) {
            this.email = pEmail;
            this.contraseña = pContraseña;
            this.rol = pRol;
            this.personasID = pPersonasID;
        
        }
    }
}
