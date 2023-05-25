namespace ProyectoFinalPrograIII
{
    public partial class Form1 : Form
    {
        public static Form1 instance = new Form1();
        private Lista listaCliente = new Lista("listaCliente");

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public Lista getlistaClientes()
        {
            return listaCliente;
        }

        private void reservaHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2();
            registro.Show();
        }

        private void reservaSalonEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 reventos = new Form3();
            reventos.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 cliente = new Form4();
            cliente.Show();

        }

        private void verificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";

            message += listaCliente.mostrarLista();

            MessageBox.Show(message);
        }
    }
}