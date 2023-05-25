using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPrograIII
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String mod = numericUpDown1.Value.ToString();
            MessageBox.Show("Hola" + numericUpDown1.Value.ToString());
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "")
            {
                chkbClienteVip.Enabled= true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbCorreo.Text != "")
            {
                btnRegistrar.Enabled = true;
                chkbClienteVip.Enabled= true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Form2 registro = new Form2();
            this.Close();
        }
    }
}
