using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 1";
            this.panel1.Controls.Clear();
            Math_1 Math1 = new Math_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Math1.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Math1);
            Math1.M = this;
            Math1.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 2";
            this.panel1.Controls.Clear();
            Math_2 Math2 = new Math_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Math2.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Math2);
            Math2.M = this;
            Math2.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 3";
            this.panel1.Controls.Clear();
            Math_3 Math3 = new Math_3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Math3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Math3);
            Math3.M = this;
            Math3.Show();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 4";
            this.panel1.Controls.Clear();
            Math_4 Math4 = new Math_4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Math4.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Math4);
            Math4.M = this;
            Math4.Show();
        }
    }
}
