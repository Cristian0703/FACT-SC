using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACT_SC
{
    class PersonasDAL
    {
        
        public static int Agregar(Persona pPersona)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion()) {

                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO tb_Personas (nombre,apellidos,telefono) VALUES ('{0}','{1}','{2}')",pPersona.nombre,pPersona.apellidos,pPersona.telefono),conexion);
                retorno = Comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static int Consultar()
        {
            int ultimo = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {  
                SqlCommand Comando = new SqlCommand(string.Format("SELECT MAX(id_Personas) FROM tb_Personas"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ultimo = reader.GetInt32(0);
                   
                    
                }
                reader.Close();
                conexion.Close();
                return ultimo;
            }

        }
    }   //SELECT MAX(id_Personas) FROM tb_Personas
}
