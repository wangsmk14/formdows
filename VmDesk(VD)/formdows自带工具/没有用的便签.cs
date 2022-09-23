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
    public partial class 没有用的便签 : Form
    {
        public 没有用的便签()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            richTextBox1.Font = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            没有用的便签 a = new 没有用的便签();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
                button2.BackColor = colorDialog1.Color;
                button3.BackColor = colorDialog1.Color;
                button4.BackColor = colorDialog1.Color;
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void 没有用的便签_Load(object sender, EventArgs e)
        {
            this.Left = 50;
            this.Top = 50;
        }

        
    }
}
