using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VmDesk_VD_
{
    public partial class Vmdesk : Form
    {
        public Vmdesk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Formdows 10";
            StreamReader a = new StreamReader("tb.vdset");
            if (a.ReadToEnd() == "1")
            {
                checkBox1.Checked = true;

            }
            a.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startup a = new startup();
            a.Show();
        }

        private void checkBox1_CheckedChanged()
        {
            if (checkBox1.Checked == true)
            {
                StreamWriter s = new StreamWriter("tb.vdset", false, Encoding.UTF8, 20);
                s.Write("1");
                s.Close();
            }
            else
            {
                StreamWriter s = new StreamWriter("tb.vdset", false, Encoding.UTF8, 20);
                s.Write("0");
                s.Close();
            }
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1_CheckedChanged();
        }

        private void button2_Click(object sender, EventArgs e)
        {


                Process p = Process.Start("formdows激活.exe");
                p.WaitForExit();//关键，等待外部程序退出后才能往下执行
        }
    }
}
