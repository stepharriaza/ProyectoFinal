﻿using System;
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
            int cantidad = decimal.ToInt32(numericUpDown1.Value);
            int mod = cantidad%4;
            
            int tipohabitacion;
            if (mod == 0)
            {
                tipohabitacion = cantidad/4;
                MessageBox.Show("Puede reservar "+ tipohabitacion.ToString() + " habitaciones dobles para " +cantidad.ToString()+ " personas");
            }
            else if (cantidad/4 <0)
            {

                if (cantidad == 3)
                {
                    MessageBox.Show("Puede reservar 2 habitaciones simples o 1 habitación doble para " + cantidad.ToString() + " personas");
                }
                else
                {
                    MessageBox.Show("Puede reservar 1 habitación simple para " + cantidad.ToString() + "  personas");
                }
            }
            else {
                tipohabitacion = (cantidad - mod)/4;
                
                
                if (mod == 3)
                {
                    MessageBox.Show("Puede reservar " + tipohabitacion.ToString() + " habitaciones dobles y 2 simples para " + cantidad.ToString() + "  personas");
                }
                else
                {
                    MessageBox.Show("Puede reservar " + tipohabitacion.ToString() + " habitaciones dobles y 1 simple para " + cantidad.ToString() + "  personas");
                }
            }
            
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "")
            {
                
                //Form1.instance.getlistaClientes().Buscar(txtbNombre.Text);
                
            }
            

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "")
            {
                btnRegistrar.Enabled = true;
                
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {



            if (!(Form1.instance.getlistaClientes().Buscar(txtbNombre.Text)))
            {

                String message = "Cliente no registrado";
                String title = "Cliente nuevo";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(message, title, buttons, icon);

                if (result == DialogResult.OK)
                {
                    Form4 cliente = new Form4();
                    cliente.Show();
                }
            }
            else
            {
                Habitaciones nuevaReservacion = new Habitaciones(numericUpDown4.Value.ToString(), decimal.ToInt32(numericUpDown1.Value), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
                Form1.instance.getlistaClientes().addHabitaciones(txtbNombre.Text, nuevaReservacion);
                this.Close();

            }
            //Form2 registro = new Form2();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.ToInt32(numericUpDown2.Value) >2) {
                MessageBox.Show("No se pueden reservar más de 2 habitaciones simples");
            }
            else
            {
                int total = (12*decimal.ToInt32(numericUpDown2.Value))+(20*decimal.ToInt32(numericUpDown3.Value));
                lblPrecio.Text = "$" + total.ToString() + ".00";
            }
            if (decimal.ToInt32(numericUpDown2.Value)==2)
            {
                
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.ToInt32(numericUpDown3.Value) >2)
            {
                MessageBox.Show("No se pueden reservar más de 2 habitaciones dobles");
            }
            else {
                int total = (12*decimal.ToInt32(numericUpDown2.Value))+(20*decimal.ToInt32(numericUpDown3.Value));
                lblPrecio.Text = "$" + total.ToString() + ".00";
            }
            if (decimal.ToInt32(numericUpDown2.Value) ==2)
            {
                
            }
        }
    }
}
