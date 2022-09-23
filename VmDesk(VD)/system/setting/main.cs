using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmDesk_VD_.formdows自带工具
{
    public partial class settings : Form
    {
        Formdows10_Desktop c;
        public settings(Formdows10_Desktop a)
        {
            InitializeComponent();

            c = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            about a = new about();
            a.MdiParent=Formdows10_Desktop.fd;
            a.Show();
        }
    }
}
