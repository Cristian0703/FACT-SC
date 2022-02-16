using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            else{
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

        }
    }
}
