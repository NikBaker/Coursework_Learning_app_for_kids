using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсовая_работа
{
    public partial class Nature_1 : Form
    {
        public Nature N;
        List<Button> buttons;
        public Nature_1()
        {
            InitializeComponent();

            button2.Enabled = false;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void dis_able(Button B)
        {
            B.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                label10.Text = "Верно!";
                button2.Enabled = true;

                con.Open();
                string query = "UPDATE tbl_users SET nature = 1 WHERE username = '" + Form1.name + "' ";
                cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                N.button1.BackColor = Color.Green;
                N.button2.Enabled = true;

                buttons = new List<Button> { N.button1, N.button2, N.button3, N.button4, N.button5, N.button6, N.button7, N.button8, N.button9, N.button10 };
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (i != 1)
                    {
                        dis_able(buttons[i]);
                    }
                }
            }
            else
            {
                label10.Text = "Неверно, попробуйте ещё";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            N.button2_Click(this, null);
        }

    }
}
