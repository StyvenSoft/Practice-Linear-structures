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
    public partial class SreenFormQueue : Form
    {
        Queue<World.Queue.Ticket> queueAerocivil = new Queue<World.Queue.Ticket>();

        public SreenFormQueue()
        {
            InitializeComponent();
        }

        private void cleanControls()
        {
            txtNumFlight.Clear();
            txtIdClient.Clear();
            txtNameClient.Clear();
            cmbAirline.ResetText();
            cmbDestinyCities.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numberFlight = Convert.ToInt32(txtNumFlight.Text);
            int idClient = Convert.ToInt32(txtIdClient.Text);
            String nameClient = txtNameClient.Text;
            String airline = cmbAirline.Text;
            String destinyCities = cmbDestinyCities.Text;
            String dateTravel = dtpDateTravel.Text;

            World.Queue.Ticket theTicket = new World.Queue.Ticket(
                    numberFlight,
                    idClient,
                    nameClient,
                    airline,
                    destinyCities,
                    dateTravel
                );
            queueAerocivil.Enqueue(theTicket);
            dvgQueue.DataSource = null;
            dvgQueue.DataSource = queueAerocivil.ToArray();
            cleanControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queueAerocivil.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el primer registro ingresado?", "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    queueAerocivil.Dequeue();
                    dvgQueue.DataSource = queueAerocivil.ToArray();
                    MessageBox.Show("Se elimino el registro!", "Atención");
                }
            }
            else
            {
                MessageBox.Show("No hay registros en la Cola!", "Atención");
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (queueAerocivil.Count > 0)
            {
                int sum = queueAerocivil.Count;
                txtTotalRegister.Text = Convert.ToString(sum);
                MessageBox.Show("Total de registros ingresados: " + txtTotalRegister.Text, "Reporte");
            }
            else
            {
                MessageBox.Show("Debe ingresar un registro", "Atención");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenOptions optionsScreen = new ScreenOptions();
            optionsScreen.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
            button1_Click(sender, e);
        }

        private void próximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReporte_Click(sender, e);
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
