using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACT_SC
{
    class Usuario1
    {
        public int usuarioID { get; set; }
        public string Email { get; set; }
        public string contraseña { get; set; }

        public int rol { get; set; }
        public int personasID { get; set; }

   

        public Usuario1() { }

        public Usuario1(int pUsuarioID, string pEmail, string pContraseña, int pRol, int pPersonasID) {
                    
            this.usuarioID = pUsuarioID;
            this.Email = pEmail;
            this.contraseña = pContraseña;
            this.rol = pRol;
            this.personasID = pPersonasID;
            
        
        }
       /* public void ConsultarUsuario(int pUsuario, string pEmail, string pContraseña, int pRol, int pPersonasID)
        {
            this.usuarioID = pUsuario;
            this.email = pEmail;
            this.contraseña = pContraseña;
            this.rol = pRol;
        }*/
        

    }
}
