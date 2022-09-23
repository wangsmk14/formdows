using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmDesk_VD_.haoluan_
{
    public partial class hvit : Form
    {
        public hvit()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Uri a = new Uri(textBox1.Text);
                webBrowser1.Url = a;
            }
        }

        private void hvit_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
            webBrowser1.Height = this.Height-21;
            webBrowser1.Width = this.Width;
        }

        private void hvit_Load(object sender, EventArgs e)
        {
            this.Left = 50;
            this.Top = 50;
        }
    }
}
