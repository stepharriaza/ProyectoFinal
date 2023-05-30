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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <100)
            {
                lblTipoSalon.Text = "Salón Sol";
            }
            else if (numericUpDown1.Value > 100 &&  numericUpDown1.Value <300)
            {
                lblTipoSalon.Text = "Salón Luna";
            }
            else {
                lblTipoSalon.Text = "La cantidad de personas supera el limite permitido";
            }
        }
    }
}
