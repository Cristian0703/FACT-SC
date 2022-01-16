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
    public partial class articulos : Form
    {
        public articulos()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAgregar, "Nuevo artículo");
            toolTip.SetToolTip(btnEliminar, "Eliminar artículo");
            toolTip.SetToolTip(btnModificar, "Modificar artículo");
            toolTip.SetToolTip(btnBuscar, "Realizar búsqueda");
            toolTip.SetToolTip(btnAtras, "Atrás");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            agregarArticulos formulario = new agregarArticulos();
            formulario.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
            
        }
    }
}
