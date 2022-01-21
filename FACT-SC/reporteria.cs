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
    public partial class Reporteria : Form
    {
        int Rol;
        public Reporteria(int pRol)
        {
            InitializeComponent();
            Rol = pRol;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio(Rol);
            formulario.Show();
            this.Hide();
        }
    }
}
