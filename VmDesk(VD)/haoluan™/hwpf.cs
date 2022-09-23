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
    public partial class hwpf : Form
    {
        SoundPlayer sp = new SoundPlayer();
        public hwpf()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Formdows10_Desktop.t = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
            sp.Stop();
            sp.SoundLocation = openFileDialog1.FileName;
            sp.PlayLooping();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp.PlayLooping();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            sp.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void hwpf_Load(object sender, EventArgs e)
        {
            this.Left = 50;
            this.Top = 50;
            if (Formdows10_Desktop.t != "")
            {
                sp.SoundLocation = Formdows10_Desktop.t;
                textBox1.Text = Formdows10_Desktop.t;
            }
        }
    }
}
