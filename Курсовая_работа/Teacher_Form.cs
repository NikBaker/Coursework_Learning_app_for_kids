using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Teacher_Form : Form
    {
        public Teacher_Form()
        {
            InitializeComponent();

            pnlNav.Height = ButHome.Height;
            pnlNav.Top = ButHome.Top;
            pnlNav.Left = ButHome.Left;
            ButHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
