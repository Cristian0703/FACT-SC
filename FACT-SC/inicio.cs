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
        public inicio()
        {
            InitializeComponent();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios formulario = new usuarios();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            articulos formulario = new articulos();
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facturacion formulario = new facturacion();
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cotizacion formulario = new cotizacion();
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parametrizacion formulario = new parametrizacion();
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reporteria formulario = new reporteria();
            formulario.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login formulario = new login();
            formulario.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
