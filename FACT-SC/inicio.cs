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
    public partial class inicio : Form
    {
        int Rol;
        public inicio(int pRol)
        {

            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            Rol = pRol;
            if (Rol != 1)
            {
                btnUsuarios.Visible = false;
                btnArticulos.Visible = false;
                btnParametrizacion.Visible = false;
                btnReporteria.Visible = false;

               /* toolTip.SetToolTip(btnUsuarios, "Usuarios");
                toolTip.SetToolTip(btnArticulos, "Artículos");
                toolTip.SetToolTip(btnFacturacion, "Facturación");
                toolTip.SetToolTip(btnReporteria, "Reportería");
                toolTip.SetToolTip(btnParametrizacion, "Parametrización");
                toolTip.SetToolTip(btnCotizacion, "Cotización");
                toolTip.SetToolTip(btnLogOut, "Cerrar sesión");*/
            }
            toolTip.SetToolTip(btnUsuarios, "Usuarios");
            toolTip.SetToolTip(btnArticulos, "Artículos");
            toolTip.SetToolTip(btnFacturacion, "Facturación");
            toolTip.SetToolTip(btnReporteria, "Reportería");
            toolTip.SetToolTip(btnParametrizacion, "Parametrización");
            toolTip.SetToolTip(btnCotizacion, "Cotización");
            toolTip.SetToolTip(btnLogOut, "Cerrar sesión");
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios formulario = new usuarios(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            articulos formulario = new articulos(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facturacion formulario = new facturacion(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cotizacion formulario = new cotizacion(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parametrizacion formulario = new parametrizacion(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporteria formulario = new Reporteria(Rol);
            formulario.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login formulario = new login();
            formulario.Show();
            this.Hide();
        }
    }
}
