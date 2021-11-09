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
    public partial class ScreenOptions : Form
    {
        public ScreenOptions()
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            ScreenFormStack formStack = new ScreenFormStack();
            formStack.Show();
            Hide();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            SreenFormQueue formQueue = new SreenFormQueue();
            formQueue.Show();
            Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ScreenFormList formLists = new ScreenFormList();
            formLists.Show();
            Hide();
        }

        private void problema1StackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScreenFormStack formStack = new ScreenFormStack();
            formStack.Show();
            Hide();
        }

        private void problema2QueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SreenFormQueue formQueue = new SreenFormQueue();
            formQueue.Show();
            Hide();
        }

        private void problema3ListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScreenFormList formLists = new ScreenFormList();
            formLists.Show();
            Hide();
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
