using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        decimal a = 0, b = 0;
        string f = "0";
        int c;
        Boolean zhuangtai,zf=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f += "1";
            updata(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f += "2";
            updata(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f += "3";
            updata(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f += "4";
            updata(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f += "5";
            updata(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f += "6";
            updata(f);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f += "7";
            updata(f);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f += "8";
            updata(f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f += "9";
            updata(f);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            f += "0";
            updata(f);
        }
        void updata(string updata_value)
        {
            textBox1.Text = updata_value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (zhuangtai == false&&a==0)
            {
                a = decimal.Parse(f);
                c = 1;
                zhuangtai = true;
                f = null;
                
                return;
            }
            if (zhuangtai||a!=0)
            {
                try
                {
                    b = decimal.Parse(f);
                }
                catch { c = 1; }
                f = null;
                
                a = js(a, b, c);
                c = 1;
                zhuangtai = false;
                return;
            }
        }
        decimal js(decimal a, decimal b, int c)
        {
            switch (c)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                case 4: if (b == 0) { MessageBox.Show("你这除数有问题呀", "FUCQ", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox1.Text = "计算器：我错误了"; return -1; } else { return a / b; }
                case 5: if (b == 0) { MessageBox.Show("你这除数有问题呀", "FUCQ", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox1.Text = "计算器：我错误了"; return -1; } else { return a % b; }
                default: MessageBox.Show("计算错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox1.Text = "计算器：我错误了"; return -1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (zhuangtai == false && a == 0)
            {
                a = decimal.Parse(f);
                c = 2;
                zhuangtai = true;
                f = null;
                
                return;
            }
            if (zhuangtai || a != 0)
            {
                try
                {
                    b = decimal.Parse(f);
                }
                catch { c = 2; }
                f = null;
                
                a = js(a, b, c);
                c = 2;
                zhuangtai = false;
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (zhuangtai == false && a == 0)
            {
                a = decimal.Parse(f);
                c = 3;
                zhuangtai = true;
                f = null;
                
                return;
            }
            if (zhuangtai || a != 0)
            {
                try
                {
                    b = decimal.Parse(f);
                }
                catch { c = 3; }
                f = null;
                
                a = js(a, b, c);
                c = 3;
                zhuangtai = false;
                return;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (zhuangtai == false && a == 0)
            {
                a = decimal.Parse(f);
                c = 4;
                zhuangtai = true;
                f = null;              
                return;
            }
            if (zhuangtai || a != 0)
            {
                try
                {
                    b = decimal.Parse(f);
                }
                catch { c = 4; }
                f = null;                
                a = js(a, b, c);
                c = 4;
                zhuangtai = false;
                return;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = decimal.Parse(f);
            zf = true;
            zhuangtai = false;
            f = js(a, b, c).ToString();
            a = 0;
            c = 0;
            updata(f);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f += ".";
            updata(f);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            c = 0;
            f = null;
            a = 0;
            b = 0;
            updata("0");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (zf)
            {
                f = "-" + f;
                updata(f);
                zf = false;
            }
            else
            {
                f = f.Substring(1, f.Length-1);
                updata(f);
                zf = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                f = f.Substring(0, f.Length - 1);
                if (f == "")
                {
                    updata("0");
                    return;
                }
            }
            catch
            {
                updata("0");
                return;
            }
            updata(f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 50;
            this.Top = 50;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (zhuangtai == false && a == 0)
            {
                a = decimal.Parse(f);
                c = 5;
                zhuangtai = true;
                f = null;

                return;
            }
            if (zhuangtai || a != 0)
            {
                try
                {
                    b = decimal.Parse(f);
                }
                catch { c = 5; }
                f = null;

                a = js(a, b, c);
                c = 5;
                zhuangtai = false;
                return;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}