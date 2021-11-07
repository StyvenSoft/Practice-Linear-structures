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
            Interface.ScreenFormStack formStack = new ScreenFormStack();
            formStack.Show();
            this.Hide();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Interface.SreenFormQueue formQueue = new SreenFormQueue();
            formQueue.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ScreenFormList formLists = new ScreenFormList();
            formLists.Show();
            Hide();
        }
    }
}
