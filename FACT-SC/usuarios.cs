using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FACT_SC
{
    public partial class usuarios : Form
    {
        int Rol;
        public usuarios(int pRol)
        {
            InitializeComponent();
            Rol = pRol;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAgregarUsuarios,"Nuevo usuario");
            toolTip.SetToolTip(btnEliminarUsuarios,"Eliminar usuario");
            toolTip.SetToolTip(btnModificarUsuario, "Modificar usuario");
            toolTip.SetToolTip(btnBuscar, "Realizar busqueda");
            toolTip.SetToolTip(btnAtras,"Atrás");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarUsuarios formulario = new agregarUsuarios(Rol);
            formulario.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio(Rol);
            formulario.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            int tamano = UsuariosDAL.Consultar();
            int[]ID = new int[tamano];
            string[] nombre = new string[tamano];
            string[] apellidos = new string[tamano];
            string[] telefono = new string[tamano];
            string[] email = new string[tamano];
            string[] contraseña = new string[tamano];
            string campoTabla = "";
            string condicion = textBox1.Text;

             switch (comboBoxBuscar.Text)
            {
                case "ID":campoTabla = "id_Usuarios";
                     break;
                case "Email": campoTabla = "email";
                     break;
                case "Contraseña": campoTabla = "contraseña";
                     break;
                case "Nombre": campoTabla = "nombre";
                    break;
                case "Apellidos":campoTabla = "apellidos";
                    break;
                case "Telefono": campoTabla = "telefono";
                    break;
                default: campoTabla ="";
                    break;
            };

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                if (!string.IsNullOrEmpty(campoTabla) && !string.IsNullOrEmpty(condicion)) {
                    SqlCommand comando = new SqlCommand(string.Format("SELECT id_Usuarios, email,contraseña, nombre, apellidos, telefono FROM tb_Usuarios, tb_Personas WHERE {0} LIKE '%{1}%' and id_Personas = personas_ID", campoTabla, condicion), conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    int columna = 0;
                    while (reader.Read())
                    {
                        ID[columna] = reader.GetInt32(0);
                        email[columna] = reader.GetString(1);
                        contraseña[columna] = reader.GetString(2);
                        nombre[columna] = reader.GetString(3);
                        apellidos[columna] = reader.GetString(4);
                        telefono[columna] = reader.GetString(5);

                        dataGridView1.Rows.Add(ID[columna], nombre[columna], apellidos[columna], telefono[columna], email[columna], contraseña[columna]);
                        columna++;
                    }
                } 
                else if(campoTabla.Equals("")) { 
                    SqlCommand comando = new SqlCommand(string.Format("SELECT id_Usuarios, email,contraseña, nombre, apellidos, telefono FROM tb_Personas P INNER JOIN tb_Usuarios U ON P.id_Personas = U.personas_ID"), conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    int columna = 0;
                    while (reader.Read()) {

                         ID[columna] = reader.GetInt32(0);
                         email[columna] = reader.GetString(1);
                         contraseña[columna] = reader.GetString(2);
                         nombre[columna] = reader.GetString(3);
                         apellidos[columna] = reader.GetString(4);
                         telefono[columna] = reader.GetString(5);
                         dataGridView1.Rows.Add(ID[columna], nombre[columna], apellidos[columna], telefono[columna], email[columna], contraseña[columna]);
                         columna++;

                     }
                 }
                else
                {
                    MessageBox.Show("Error en la consulta, intente nueva vez", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }
    }
}
