using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmDesk_VD_
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void startup_Shown(object sender, EventArgs e)
        {
            for (int a = 0; a != 101; a++) { progressBar1.Value = a; Delay(10); }
            Formdows10_Desktop b = new Formdows10_Desktop();
            b.Show();
            this.Close();
        }
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }

        private void startup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
