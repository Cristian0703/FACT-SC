using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACT_SC
{
    class UsuariosDAL
    {
        public static int Agregar(Usuario1 pUsuarios) {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion()) {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO tb_Usuarios (email,contraseña,personas_ID,rol_ID) VALUES ('{0}','{1}','{2}',{3})", pUsuarios.email, pUsuarios.contraseña,pUsuarios.personasID,pUsuarios.rol), conexion);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

       /* public static List<Usuario1> ConsultaUsuarios()
        {
            List<Usuario1> lista = new List<Usuario1>();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT id FROM "))
            }
        }*/
    }
}
