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
    public partial class Russ_5 : Form
    {
        public Russ R;
        List<Button> buttons;

        public Russ_5()
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
            if ((textBox1.Text == "столы") && (textBox2.Text == "цветы" ) && (textBox3.Text == "хлеба") && (textBox4.Text == "мосты"))
            {
                label10.Text = "Верно!";
                button2.Enabled = true;

                con.Open();
                string query = "UPDATE tbl_users SET russ = 5 WHERE username = '" + Form1.name + "' ";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                R.button5.BackColor = Color.Green;
                R.button6.Enabled = true;

                buttons = new List<Button> { R.button1, R.button2, R.button3, R.button4, R.button5, R.button6, R.button7, R.button8, R.button9, R.button10 };
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (i != 5)
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
    }
}
