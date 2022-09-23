using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace VmDesk_VD_.system
{
    public partial class meg : Form
    {
        public meg(string a,string b)
        {
            InitializeComponent();
            this.Text = a;
            label1.Text = b;
            this.Show();
        }
        static void Show(string a,string text)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meg_Load(object sender, EventArgs e)
        {
            this.MdiParent = Formdows10_Desktop.fd;
            SoundPlayer a = new SoundPlayer();
            a.SoundLocation = Application.StartupPath + @"/media/error.wav";
            a.Play();
            if (new StreamReader("tb.vdset").ReadToEnd() == "1")
            {
                NotifyIcon b = Formdows10_Desktop.notifyicon;
                b.ShowBalloonTip(1000, "提示消息转换", this.Text + "\r" + label1.Text, ToolTipIcon.Info);
            }
        }
    }
}
