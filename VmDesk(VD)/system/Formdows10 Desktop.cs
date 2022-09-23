using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace VmDesk_VD_
{
    public partial class Formdows10_Desktop : Form
    {
        static public string t="";
        static public Formdows10_Desktop fd;
        static public NotifyIcon notifyicon;
        public Formdows10_Desktop()
        {
            InitializeComponent();
            fd = this;
            notifyicon = notifyIcon1;
        }

        private void Formdows10_Desktop_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Timer t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = 100;
            t.Start();
            SoundPlayer a = new SoundPlayer();
            a.SoundLocation = Application.StartupPath + @"/media/startup.wav";
            a.Play();
            notifyIcon1.ShowBalloonTip(2000, "VmDesk", "Formdows10虚拟机已启动", ToolTipIcon.Info);
            
        }

        void t_Tick(object sender, EventArgs e)
        {
            button2.Text=System.DateTime.Now.ToString("T");             
            button2.Text+="\r"+System.DateTime.Now.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }
        public void HWPshow()
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (time1.Visible)
            {
                time1.Visible = false;
            }
            else
            {
                time1.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            hwpf hwp = new hwpf();
            hwp.MdiParent = this;
            hwp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            hvpf a = new hvpf();
            a.MdiParent = this;
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            calc.Form1 a = new calc.Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            没有用的便签 a = new 没有用的便签();
            a.MdiParent = this;
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            formdows自带工具.taskmgr a = new formdows自带工具.taskmgr();
            a.MdiParent = this;
            a.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            haoluan_.hvit a = new haoluan_.hvit();
            a.MdiParent = this;
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VmDesk_VD_.formdows自带工具.settings a = new formdows自带工具.settings(this);
            a.MdiParent = this;
            a.Show();
            panel1.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
            this.Activate();
            this.Focus();
        }

        private void Formdows10_Desktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确认要退出虚拟机吗", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;                
            }
            else
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(2000, "VmDesk", "Formdows10虚拟机已关闭", ToolTipIcon.Info);
                startup.Delay(3000);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formdows自带工具.notopad__ a = new formdows自带工具.notopad__();
            a.MdiParent = this;
            a.Show();
            panel1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdows10_Desktop_SizeChanged(object sender, EventArgs e)
        {
            button2.Left = this.Width - 110;
            time1.Left = this.Width - 458;
            button1.Left = button2.Left - 45;
            panel3.Left = this.Width - 315;
            panel1.Left = panel3.Left - 30;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        //VD 1.0 oc皓乱：douyin，bilibili
    }
}
