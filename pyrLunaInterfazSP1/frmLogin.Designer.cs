namespace pyrLunaInterfazSP1
{
    partial class frmLogin
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
            lblBienvenido = new Label();
            lblSintepartSRL = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 30F);
            lblBienvenido.Location = new Point(145, 117);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(217, 54);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenida";
            // 
            // lblSintepartSRL
            // 
            lblSintepartSRL.AutoSize = true;
            lblSintepartSRL.BackColor = SystemColors.ActiveCaption;
            lblSintepartSRL.Font = new Font("Segoe UI", 30F);
            lblSintepartSRL.Location = new Point(119, 197);
            lblSintepartSRL.Name = "lblSintepartSRL";
            lblSintepartSRL.Size = new Size(268, 54);
            lblSintepartSRL.TabIndex = 1;
            lblSintepartSRL.Text = "Sintepart SRL.";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 369);
            Controls.Add(lblSintepartSRL);
            Controls.Add(lblBienvenido);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblSintepartSRL;
    }
}