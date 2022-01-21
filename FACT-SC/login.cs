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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAceptar, "Iniciar sesión");
            toolTip.SetToolTip(btnSalir,"Salir del sistema");
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string usuario = textBox1.Text, contraseña = textBox2.Text;
                if (!string.IsNullOrWhiteSpace(usuario)&& !string.IsNullOrWhiteSpace(contraseña))
                {
                    string realPass = "";
                    int Rol = 0;
                    SqlCommand comando = new SqlCommand(string.Format("SELECT contraseña,rol_ID FROM tb_Usuarios WHERE id_Usuarios = {0}",usuario),conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        realPass = reader.GetString(0);
                        Rol = reader.GetInt32(1);
                    }
                    if (contraseña.Equals(realPass))
                    {
                        inicio formulario = new inicio(Rol);
                        MessageBox.Show("Bienvenido al Sistema", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.None);
                        formulario.Show();
                        this.Hide();
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                        MessageBox.Show("Código usuario y/o contraseña incorrectos", "Inicio Sesión Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("Ingrese usuario y contraseña");
                }

            }
          /*  inicio formulario = new inicio();
            formulario.Show();
            this.Hide();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
