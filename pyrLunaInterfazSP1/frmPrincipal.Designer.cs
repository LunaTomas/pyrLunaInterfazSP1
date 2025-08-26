namespace pyrLunaInterfazSP1
{
    partial class frmPrincipal
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14F);
            lblUsuario.Location = new Point(26, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 14F);
            lblContraseña.Location = new Point(26, 65);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 14F);
            lblModulo.Location = new Point(26, 115);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(78, 25);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 14F);
            txtContraseña.Location = new Point(173, 62);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(241, 32);
            txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.ForeColor = Color.FromArgb(128, 128, 255);
            txtUsuario.Location = new Point(173, 12);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(241, 32);
            txtUsuario.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14F);
            btnAceptar.Location = new Point(456, 12);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 32);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14F);
            btnCancelar.Location = new Point(456, 62);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbModulo
            // 
            cbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModulo.FormattingEnabled = true;
            cbModulo.IntegralHeight = false;
            cbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cbModulo.Location = new Point(173, 115);
            cbModulo.Name = "cbModulo";
            cbModulo.Size = new Size(241, 23);
            cbModulo.TabIndex = 8;
            cbModulo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 153);
            Controls.Add(cbModulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cbModulo;
    }
}