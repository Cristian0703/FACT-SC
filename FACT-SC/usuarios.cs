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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAgregarUsuarios,"Nuevo usuario");
            toolTip.SetToolTip(btnEliminarUsuarios,"Eliminar usuario");
            toolTip.SetToolTip(btnModificarUsuario, "Modificar usuario");
            toolTip.SetToolTip(btnBuscar, "Realizar busqueda");
            toolTip.SetToolTip(btnAtras,"Atrás");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarUsuarios formulario = new agregarUsuarios();
            formulario.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
        }
    }
}
