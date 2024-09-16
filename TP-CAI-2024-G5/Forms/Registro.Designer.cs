namespace TP_CAI_2024_G5
{
    partial class FrmRegistro
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
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPerifl = new System.Windows.Forms.Label();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdSup = new System.Windows.Forms.RadioButton();
            this.rdVendedor = new System.Windows.Forms.RadioButton();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAlta.Location = new System.Drawing.Point(24, 20);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(243, 20);
            this.lblTituloAlta.TabIndex = 0;
            this.lblTituloAlta.Text = "Registrar o Modificar Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Nombre de Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(25, 103);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Nueva Contraseña";
            // 
            // lblPerifl
            // 
            this.lblPerifl.AutoSize = true;
            this.lblPerifl.Location = new System.Drawing.Point(31, 135);
            this.lblPerifl.Name = "lblPerifl";
            this.lblPerifl.Size = new System.Drawing.Size(84, 13);
            this.lblPerifl.TabIndex = 6;
            this.lblPerifl.Text = "Perfil de Usuario";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Location = new System.Drawing.Point(136, 132);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(88, 17);
            this.rdAdmin.TabIndex = 7;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrador";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdSup
            // 
            this.rdSup.AutoSize = true;
            this.rdSup.Location = new System.Drawing.Point(234, 131);
            this.rdSup.Name = "rdSup";
            this.rdSup.Size = new System.Drawing.Size(75, 17);
            this.rdSup.TabIndex = 8;
            this.rdSup.TabStop = true;
            this.rdSup.Text = "Supervisor";
            this.rdSup.UseVisualStyleBackColor = true;
            // 
            // rdVendedor
            // 
            this.rdVendedor.AutoSize = true;
            this.rdVendedor.Location = new System.Drawing.Point(322, 131);
            this.rdVendedor.Name = "rdVendedor";
            this.rdVendedor.Size = new System.Drawing.Size(71, 17);
            this.rdVendedor.TabIndex = 9;
            this.rdVendedor.TabStop = true;
            this.rdVendedor.Text = "Vendedor";
            this.rdVendedor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(164, 174);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(131, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(131, 100);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(140, 20);
            this.txtNuevaContraseña.TabIndex = 12;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 209);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.rdVendedor);
            this.Controls.Add(this.rdSup);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.lblPerifl);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTituloAlta);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPerifl;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdSup;
        private System.Windows.Forms.RadioButton rdVendedor;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
    }
}