using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Russ : Form
    {
        public Russ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Russ_1 Russ1 = new Russ_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            label1.Text = "Задание 1";
            this.panel1.Controls.Clear();
            Russ1.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Russ1);
            Russ1.R = this;
            Russ1.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Russ_2 Russ2 = new Russ_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            label1.Text = "Задание 2";
            this.panel1.Controls.Clear();
            Russ2.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Russ2);
            Russ2.R = this;
            Russ2.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Russ_3 Russ3 = new Russ_3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            label1.Text = "Задание 3";
            this.panel1.Controls.Clear();
            Russ3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Russ3);
            Russ3.R = this;
            Russ3.Show();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Russ_4 Russ4 = new Russ_4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            label1.Text = "Задание 4";
            this.panel1.Controls.Clear();
            Russ4.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Russ4);
            Russ4.R = this;
            Russ4.Show();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            Russ_5 Russ5 = new Russ_5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            label1.Text = "Задание 5";
            this.panel1.Controls.Clear();
            Russ5.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Russ5);
            Russ5.R = this;
            Russ5.Show();
        }
    }
}
