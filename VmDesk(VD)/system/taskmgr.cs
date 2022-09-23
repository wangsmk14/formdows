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

namespace VmDesk_VD_.formdows自带工具
{
    public partial class taskmgr : Form
    {
        public taskmgr()
        {
            InitializeComponent();
        }
        Timer tr = new Timer();
        Random rd = new Random();
        private void taskmgr_Load(object sender, EventArgs e)
        {
            StreamReader a = new StreamReader(Application.StartupPath + @"\hardwera\cpu.txt");
            textBox1.Text = a.ReadToEnd();
            a.Close();
            a = new StreamReader(Application.StartupPath + @"\hardwera\ram.txt");
            textBox2.Text = a.ReadToEnd();
            a.Close();
            a = new StreamReader(Application.StartupPath + @"\hardwera\rom.txt");
            textBox3.Text = a.ReadToEnd();
            a.Close();
            a = new StreamReader(Application.StartupPath + @"\hardwera\netwok.txt");
            textBox4.Text = a.ReadToEnd();
            a.Close();
            a = new StreamReader(Application.StartupPath + @"\hardwera\gpu.txt");
            textBox5.Text = a.ReadToEnd();
            a.Close();
            tr.Interval = 1000;
            tr.Tick += new EventHandler(tr_Tick);
            tr.Start();
            this.Left = 50;
            this.Top = 50;
        }

        void tr_Tick(object sender, EventArgs e)
        {
            label1.Text = "使用率：" + rd.Next(0, 101).ToString() + "%";
            label2.Text = "使用率：" + rd.Next(0, 101).ToString() + "%";
            label3.Text = "使用率：" + rd.Next(0, 101).ToString() + "%";
            label4.Text = "使用率：" + rd.Next(0, 101).ToString() + "%";
            label5.Text = "使用率：" + rd.Next(0, 101).ToString() + "%";
        }

        private void taskmgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            tr.Stop();
        }
    }
}