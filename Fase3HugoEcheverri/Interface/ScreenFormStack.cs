using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3HugoEcheverri.Interface
{
    public partial class ScreenFormStack : Form
    {
        Stack<World.Stack.Invoice> pileAcueduct = new Stack<World.Stack.Invoice>();

        public ScreenFormStack()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtConsumMonth.Text != "")
            {
                int cubicMeterValue = 1500;
                double comsumMonth = Convert.ToDouble(txtConsumMonth.Text);

                txtTotalPay.Text = Convert.ToString(comsumMonth * cubicMeterValue);
            }
            else
            {
                MessageBox.Show("Debe ingresar un Consumo mes (mts3)"); 
            } 
        }

        private void cleanControls()
        {
            txtInvoice.Clear();
            txtEnrollment.Clear();
            txtMonthBilled.ResetText();
            txtUsername.Clear();
            txtAddress.Clear();
            cmbSocialStratum.ResetText();
            txtConsumMonth.Clear();
            cmbCategory.ResetText();
            txtTotalPay.Clear();
        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInvoice.Text) ||
                String.IsNullOrEmpty(txtEnrollment.Text) 
                )
            {
                errorProvider1.SetError(txtInvoice, "Debe ingresar");
                errorProvider1.SetError(txtEnrollment, "Debe ingresar");
                return;
            }

            string numInvoice = txtInvoice.Text;
            string numEnrollment = txtEnrollment.Text;
            string monthBilled = txtMonthBilled.Text;
            string userName = txtUsername.Text;
            string address = txtAddress.Text;
            int stratum = Int32.Parse(cmbSocialStratum.Text);
            double consumMonth = Double.Parse(txtConsumMonth.Text);
            string category = cmbCategory.Text;
            double totalConsum = Double.Parse(txtTotalPay.Text);
            string datePayment = dtpPayment.Text;

            World.Stack.Invoice theInvoice = new World.Stack.Invoice(
                numInvoice,
                numEnrollment,
                monthBilled,
                userName,
                address,
                stratum,
                category,
                consumMonth,
                totalConsum,
                datePayment
                );
            pileAcueduct.Push(theInvoice);
            dgvStack.DataSource = null;
            dgvStack.DataSource = pileAcueduct.ToArray();
            cleanControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (pileAcueduct.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el ultimo registro ingresado?", "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pileAcueduct.Pop();
                    dgvStack.DataSource = pileAcueduct.ToArray();
                    MessageBox.Show("Se elimino el registro!", "Atención");
                }
            }
            else
            {
                MessageBox.Show("No hay registros en la Pila!", "Atención");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            if (pileAcueduct.Count > 0)
            {
                double sum = 0;
                foreach(DataGridViewRow row in dgvStack.Rows)
                {
                    if (row.Cells[8].Value != null)
                        sum += Convert.ToDouble(row.Cells[8].Value);
                }
                totalRaised.Text = Convert.ToString(sum);
                MessageBox.Show("Total Recaudo: " + sum.ToString(), "Servicio de acueducto");
            } else
            {
                MessageBox.Show("Debe ingresar un registro", "Atención");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ScreenOptions optionsScreen = new ScreenOptions();
            optionsScreen.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void prToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReport_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
    }
}
