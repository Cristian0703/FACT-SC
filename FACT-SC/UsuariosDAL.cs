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
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO tb_Usuarios (email,contraseña,personas_ID,rol_ID) VALUES ('{0}','{1}','{2}',{3})", pUsuarios.Email, pUsuarios.contraseña,pUsuarios.personasID,pUsuarios.rol), conexion);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static int Consultar()
        {
            int ultimo = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT COUNT(id_Usuarios) FROM tb_Usuarios"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ultimo = reader.GetInt32(0);


                }
                reader.Close();
                conexion.Close();
                return ultimo;
            }

           /* public static List<Usuario1> ConsultaUsuarios()
            {
 
             List<Usuario1> lista = new List<Usuario1>();


                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(string.Format("SELECT id_Usuarios, email, contraseña FROM (tb_Usuarios U INNER JOIN tb_Personas P ON P.id_Personas = U.personas_ID)"),conexion);
                    // SqlCommand Comando = new SqlCommand(string.Format("SELECT * FROM tb_Usuarios"),conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario1 pusuario = new Usuario1();
                       
                        pusuario.usuarioID = reader.GetInt32(0);                      
                        pusuario.Email = reader.GetString(1);
                        pusuario.contraseña = reader.GetString(2);


                        lista.Add(pusuario);

                    }
                    return lista;
                }*/
             
         }
    }
}
