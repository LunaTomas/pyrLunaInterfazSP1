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
            lstModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14F);
            lblUsuario.Location = new Point(19, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 14F);
            lblContraseña.Location = new Point(20, 70);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 14F);
            lblModulo.Location = new Point(19, 124);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(78, 25);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 14F);
            txtContraseña.Location = new Point(167, 63);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(241, 32);
            txtContraseña.TabIndex = 2;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.ForeColor = Color.FromArgb(128, 128, 255);
            txtUsuario.Location = new Point(167, 13);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(241, 32);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 14F);
            btnAceptar.Location = new Point(450, 13);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 32);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14F);
            btnCancelar.Location = new Point(450, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.Enabled = false;
            lstModulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstModulo.FormattingEnabled = true;
            lstModulo.IntegralHeight = false;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(167, 116);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(241, 33);
            lstModulo.TabIndex = 3;
            lstModulo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 163);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lstModulo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Button btnAceptar;
        private Button btnCancelar;

    }
}