using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyrLunaInterfazSP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            lstModulo.SelectedIndex = -1;
            txtUsuario.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "")
                {
                    btnAceptar.Enabled = false;
                }
                else
                {
                    btnAceptar.Enabled = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
                txtContraseña.Text = "";
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                lstModulo.Enabled = false;
                lstModulo.SelectedIndex = -1;
            }
            else
            {
                lstModulo.Enabled = true;
            }
        }
    }
}
