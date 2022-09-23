using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmDesk_VD_.system.setting
{
    public partial class easteggs : Form
    {
        public easteggs()
        {
            InitializeComponent();
        }

        private void easteggs_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath+@"\media\1.mp4";
            this.MdiParent = Formdows10_Desktop.fd;
            axWindowsMediaPlayer1.Height = this.Height + 30;
        }

        private void easteggs_SizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Height = this.Height+30;
            axWindowsMediaPlayer1.Width = this.Width;
        }
    }
}
