using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VmDesk_VD_.formdows自带工具
{
    public partial class notopad__ : Form
    {
        bool seva=true;
        public notopad__()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seva)
            {
                openFileDialog1.ShowDialog();
            }
            else
            {
                system.meg a = new system.meg("提示","请不要抛弃未保存的文件");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            seva = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader a = new StreamReader(openFileDialog1.FileName,Encoding.Default);
            richTextBox1.Text= a.ReadToEnd();
            seva = true;
            a.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.Delete(saveFileDialog1.FileName);
            startup.Delay(50);
            FileStream b = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite, 8);
            byte[] ba = System.Text.Encoding.Default.GetBytes(richTextBox1.Text);
            b.Write(ba, 0, richTextBox1.Text.Length);
            seva = true;
            b.Close();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void notopad___SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Height = this.Height - 25;
            richTextBox1.Width = this.Width;
        }
    }
}
