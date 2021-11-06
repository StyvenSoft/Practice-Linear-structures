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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string numInvoice = txtInvoice.Text;
            string numEnrollment = txtEnrollment.Text;
            string monthBilled = txtMonthBilled.Text;
            string userName = txtUsername.Text;
            string address = txtAddress.Text;
            int stratum = Int32.Parse(cmbSocialStratum.Text);
            double consumMonth = Double.Parse(txtConsumMonth.Text);
            string category = cmbCategory.Text;

            World.Stack.Invoice theInvoice = new World.Stack.Invoice(
                numInvoice,
                numEnrollment,
                monthBilled,
                userName,
                address,
                stratum,
                category,
                consumMonth
                );
            pileAcueduct.Push(theInvoice);
            dgvStack.DataSource = null;
            dgvStack.DataSource = pileAcueduct.ToArray();
        }
    }
}
