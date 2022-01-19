using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACT_SC
{
    public class Conexion
    {
        
        public static SqlConnection ObtenerConexion() {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M3BTSI6;Initial Catalog=db_facturacion;Integrated Security=True");
            conexion.Open();
            return conexion;

        }
    }
}
