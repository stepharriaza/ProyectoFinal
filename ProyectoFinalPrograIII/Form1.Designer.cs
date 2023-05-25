namespace ProyectoFinalPrograIII
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarReservaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaSalonEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.realizarReservaciónToolStripMenuItem,
            this.verificarHabitacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // realizarReservaciónToolStripMenuItem
            // 
            this.realizarReservaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaHabitacionesToolStripMenuItem,
            this.reservaSalonEventosToolStripMenuItem});
            this.realizarReservaciónToolStripMenuItem.Name = "realizarReservaciónToolStripMenuItem";
            this.realizarReservaciónToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.realizarReservaciónToolStripMenuItem.Text = "Realizar reservación";
            // 
            // reservaHabitacionesToolStripMenuItem
            // 
            this.reservaHabitacionesToolStripMenuItem.Name = "reservaHabitacionesToolStripMenuItem";
            this.reservaHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.reservaHabitacionesToolStripMenuItem.Text = "Reserva Habitaciones";
            this.reservaHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.reservaHabitacionesToolStripMenuItem_Click);
            // 
            // reservaSalonEventosToolStripMenuItem
            // 
            this.reservaSalonEventosToolStripMenuItem.Name = "reservaSalonEventosToolStripMenuItem";
            this.reservaSalonEventosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.reservaSalonEventosToolStripMenuItem.Text = "Reserva Salon Eventos";
            this.reservaSalonEventosToolStripMenuItem.Click += new System.EventHandler(this.reservaSalonEventosToolStripMenuItem_Click);
            // 
            // verificarHabitacionesToolStripMenuItem
            // 
            this.verificarHabitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarClientesToolStripMenuItem});
            this.verificarHabitacionesToolStripMenuItem.Name = "verificarHabitacionesToolStripMenuItem";
            this.verificarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.verificarHabitacionesToolStripMenuItem.Text = "Registros";
            // 
            // verificarClientesToolStripMenuItem
            // 
            this.verificarClientesToolStripMenuItem.Name = "verificarClientesToolStripMenuItem";
            this.verificarClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.verificarClientesToolStripMenuItem.Text = "Verificar Clientes";
            this.verificarClientesToolStripMenuItem.Click += new System.EventHandler(this.verificarClientesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalPrograIII.Properties.Resources.imagenHotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 434);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listado Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem realizarReservaciónToolStripMenuItem;
        private ToolStripMenuItem verificarHabitacionesToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem reservaHabitacionesToolStripMenuItem;
        private ToolStripMenuItem reservaSalonEventosToolStripMenuItem;
        private ToolStripMenuItem verificarClientesToolStripMenuItem;
        private Button button1;
    }
}