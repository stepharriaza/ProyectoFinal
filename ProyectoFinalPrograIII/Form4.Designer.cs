namespace ProyectoFinalPrograIII
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbClienteVip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(413, 387);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(182, 29);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.Text = "Registrar Evento";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(196, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 39);
            this.label4.TabIndex = 37;
            this.label4.Text = "Registro Clientes";
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(164, 237);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(431, 27);
            this.txtbTelefono.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Telefono:";
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(164, 188);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(430, 27);
            this.txtbCorreo.TabIndex = 33;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(224, 139);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(370, 27);
            this.txtbNombre.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = " E - mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre Cliente:";
            // 
            // chkbClienteVip
            // 
            this.chkbClienteVip.AutoSize = true;
            this.chkbClienteVip.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkbClienteVip.Enabled = false;
            this.chkbClienteVip.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbClienteVip.Location = new System.Drawing.Point(164, 301);
            this.chkbClienteVip.Name = "chkbClienteVip";
            this.chkbClienteVip.Size = new System.Drawing.Size(354, 21);
            this.chkbClienteVip.TabIndex = 42;
            this.chkbClienteVip.Text = "El cliente tiene cuenta con memebresia vip";
            this.chkbClienteVip.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(686, 463);
            this.Controls.Add(this.chkbClienteVip);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrar;
        private Label label4;
        private TextBox txtbTelefono;
        private Label label3;
        private TextBox txtbCorreo;
        private TextBox txtbNombre;
        private Label label2;
        private Label label1;
        private CheckBox chkbClienteVip;
    }
}