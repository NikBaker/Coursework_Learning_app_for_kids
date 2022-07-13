using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Nature : Form
    {
        public Nature()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 1";
            this.panel1.Controls.Clear();
            Nature_1 Nature1 = new Nature_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Nature1.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Nature1);
            Nature1.N = this;
            Nature1.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 2";
            this.panel1.Controls.Clear();
            Nature_2 Nature2 = new Nature_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Nature2.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Nature2);
            Nature2.N = this;
            Nature2.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Задание 3";
            this.panel1.Controls.Clear();
            Nature_3 Nature3 = new Nature_3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Nature3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Nature3);
            Nature3.N = this;
            Nature3.Show();
        }
    }
}
