﻿using System;
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
    }
}
