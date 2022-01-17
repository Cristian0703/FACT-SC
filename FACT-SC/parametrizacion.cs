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
    public partial class parametrizacion : Form
    {
        public parametrizacion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            inicio formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int p = checkedListBox2.Items.Count;
            if (checkBox1.Checked)
            {
                for (int i = 0; i < p; i++) {
                    checkedListBox2.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                for (int i = 0; i < p; i++)
                {
                    checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
                }
            }    
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int p = checkedListBox1.Items.Count;
            if (checkBox2.Checked)
            {
                for (int i = 0; i < p; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                for (int i = 0; i < p; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}
