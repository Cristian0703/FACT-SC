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
    public partial class facturacion : Form
    {
        public facturacion()
        {

            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAtras,"Atrás");
            toolTip.SetToolTip(btnAgregar, "Agrega artículo a la compra");
            toolTip.SetToolTip(btnEliminar, "Eliminar artículo");
            toolTip.SetToolTip(btnModificar, "Modificar artículo");
            toolTip.SetToolTip(btnBuscar, "Realizar búsqueda");
            toolTip.SetToolTip(btnPagar, "Pagar");
            toolTip.SetToolTip(btnImprimir,"Imprimir fáctura");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
