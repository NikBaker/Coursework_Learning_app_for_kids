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
    public partial class Russ_3 : Form
    {
        public Russ R;
        List<Button> buttons;
        public Russ_3()
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
            if ((textBox1.Text == "весла" || textBox1.Text == "вёсла") && (textBox2.Text == "гнезда" || textBox2.Text == "гнёзда") && (textBox3.Text == "пчелы" || textBox3.Text == "пчёлы") && (textBox4.Text == "мухи"))
            {
                label10.Text = "Верно!";
                button2.Enabled = true;

                con.Open();
                string query = "UPDATE tbl_users SET russ = 3 WHERE username = '" + Form1.name + "' ";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                R.button3.BackColor = Color.Green;
                R.button4.Enabled = true;

                buttons = new List<Button> { R.button1, R.button2, R.button3, R.button4, R.button5, R.button6, R.button7, R.button8, R.button9, R.button10 };
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (i != 3)
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
            R.button4_Click(this, null);
        }
    }
}
