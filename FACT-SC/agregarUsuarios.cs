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
    public partial class agregarUsuarios : Form
    {
  
        public agregarUsuarios()

        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnGuardarUsuarios, "Guardar usuario");
            toolTip.SetToolTip(btnAtras, "Atrás");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

                if (checkBox1.Checked) {
                    checkBox1.Text = "ocultar contraseña";
                    txtPassword.PasswordChar = '\0';
                }
                else {
                    checkBox1.Text = "mostrar contraseña";
                    txtPassword.PasswordChar = '*';
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtApellidos.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(maskedTextBox1.Text) && !String.IsNullOrEmpty(txtEmail.Text)
              && !String.IsNullOrEmpty(txtPassword.Text))
            {
                Persona persona = new Persona();
            persona.nombre = txtNombre.Text;
            persona.apellidos = txtApellidos.Text;
            persona.telefono = maskedTextBox1.Text;
          
                int resultado = PersonasDAL.Agregar(persona);
             
                int ultimo = PersonasDAL.Consultar();
                int rol = 0;

                if (radioAdmin.Checked)
                {
                    rol = 1;
                }
                else
                {
                    rol = 2;
                }

                Usuario1 usuarios = new Usuario1();
                usuarios.contraseña = txtPassword.Text;
                usuarios.email = txtEmail.Text;
                usuarios.personasID = ultimo;
                usuarios.rol = rol;

                int resultado2 = UsuariosDAL.Agregar(usuarios);

                if (resultado2 > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se guardaron datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

    }
}
