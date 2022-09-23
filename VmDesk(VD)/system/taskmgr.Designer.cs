namespace VmDesk_VD_.formdows自带工具
{
    partial class taskmgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RAM = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rom = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.net = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RAM.SuspendLayout();
            this.CPU.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.rom.SuspendLayout();
            this.net.SuspendLayout();
            this.gpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RAM
            // 
            this.RAM.Controls.Add(this.textBox2);
            this.RAM.Controls.Add(this.label2);
            this.RAM.Location = new System.Drawing.Point(4, 22);
            this.RAM.Name = "RAM";
            this.RAM.Padding = new System.Windows.Forms.Padding(3);
            this.RAM.Size = new System.Drawing.Size(311, 64);
            this.RAM.TabIndex = 1;
            this.RAM.Text = "内存";
            this.RAM.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(294, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "使用率：  %";
            // 
            // CPU
            // 
            this.CPU.Controls.Add(this.textBox1);
            this.CPU.Controls.Add(this.label1);
            this.CPU.Location = new System.Drawing.Point(4, 22);
            this.CPU.Name = "CPU";
            this.CPU.Padding = new System.Windows.Forms.Padding(3);
            this.CPU.Size = new System.Drawing.Size(311, 64);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(294, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用率：  %";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CPU);
            this.tabControl1.Controls.Add(this.RAM);
            this.tabControl1.Controls.Add(this.rom);
            this.tabControl1.Controls.Add(this.net);
            this.tabControl1.Controls.Add(this.gpu);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 90);
            this.tabControl1.TabIndex = 0;
            // 
            // rom
            // 
            this.rom.Controls.Add(this.textBox3);
            this.rom.Controls.Add(this.label3);
            this.rom.Location = new System.Drawing.Point(4, 22);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(311, 64);
            this.rom.TabIndex = 2;
            this.rom.Text = "硬盘";
            this.rom.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(294, 21);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "使用率：  %";
            // 
            // net
            // 
            this.net.Controls.Add(this.textBox4);
            this.net.Controls.Add(this.label4);
            this.net.Location = new System.Drawing.Point(4, 22);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(311, 64);
            this.net.TabIndex = 3;
            this.net.Text = "网络";
            this.net.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(294, 21);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "使用率：  %";
            // 
            // gpu
            // 
            this.gpu.Controls.Add(this.textBox5);
            this.gpu.Controls.Add(this.label5);
            this.gpu.Location = new System.Drawing.Point(4, 22);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(311, 64);
            this.gpu.TabIndex = 4;
            this.gpu.Text = "GPU";
            this.gpu.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 10);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(294, 21);
            this.textBox5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "使用率：  %";
            // 
            // taskmgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 89);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "taskmgr";
            this.Text = "资源监视器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.taskmgr_FormClosing);
            this.Load += new System.EventHandler(this.taskmgr_Load);
            this.RAM.ResumeLayout(false);
            this.RAM.PerformLayout();
            this.CPU.ResumeLayout(false);
            this.CPU.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.rom.ResumeLayout(false);
            this.rom.PerformLayout();
            this.net.ResumeLayout(false);
            this.net.PerformLayout();
            this.gpu.ResumeLayout(false);
            this.gpu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage RAM;
        private System.Windows.Forms.TabPage CPU;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage rom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage net;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage gpu;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;

    }
}