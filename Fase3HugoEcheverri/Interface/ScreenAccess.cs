using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3HugoEcheverri
{
    public partial class ScreenAccess : Form
    {
        public ScreenAccess()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String passwordDefault = "123";

            if (txtPassword.Text == passwordDefault)
            {
                Interface.ScreenOptions structuredForms = new Interface.ScreenOptions();
                structuredForms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡La contraseña es incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
