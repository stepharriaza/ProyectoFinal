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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();

            lblErrorNombre.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorTelefono.Visible = false;

            bool verificado = true;
            if (txtbNombre.Text == "")
            {
                lblErrorNombre.Visible = true;
                verificado = false;

            }
            if (txtbCorreo.Text == "")
            {
                lblErrorCorreo.Visible = true;
                verificado = false;
            }
            if (txtbTelefono.Text == "") 
            {
                lblErrorTelefono.Visible = true;
                verificado = false;
            }
            if (verificado)
            {
                lblErrorNombre.Visible = false;
                lblErrorCorreo.Visible = false;
                lblErrorTelefono.Visible = false;
                nuevoCliente.setName(txtbNombre.Text);
                nuevoCliente.setCorreo(txtbCorreo.Text);
                nuevoCliente.setTelefono(txtbTelefono.Text);

                Nodo nuevoNodo = new Nodo(nuevoCliente);

                Form1.instance.getlistaClientes().Insertar(nuevoNodo);

                txtbNombre.Text = "";
                txtbCorreo.Text = "";
                txtbTelefono.Text = "";

            }
        }

        
    }
}
