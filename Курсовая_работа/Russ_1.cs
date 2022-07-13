using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Russ_1 : Form
    {
        List<Label> emphasises_first_word;
        List<Label> emphasises_second_word;
        List<Label> emphasises_third_word;
        List<Label> emphasises_fouth_word;
        List<Label> emphasises;

        List<Button> buttons;

        public Russ R;
        public Russ_1()
        {
            InitializeComponent();
            emphasises_first_word = new List<Label> { lb1, lb2 };
            emphasises_second_word = new List<Label> { lb3, lb4 };
            emphasises_third_word = new List<Label> { lb5, lb6, lb7 };
            emphasises_fouth_word = new List<Label> { lb8, lb9, lb10, lb11 };
            emphasises = new List<Label> { lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, lb11 };

            button2.Enabled = false;
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void put_emphasis(List<Label> word, int pos)
        {
            for (int i = 0; i < word.Count; i++)
            {
                if (word[i] != word[pos])
                {
                    word[i].Text = "";
                }
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            lb1.Text = "       /";
            put_emphasis(emphasises_first_word, 0);
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            lb2.Text = "    /";
            put_emphasis(emphasises_first_word, 1);
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            lb3.Text = "      /";
            put_emphasis(emphasises_second_word, 0);
        }

        private void lb4_Click(object sender, EventArgs e)
        {
            lb4.Text = "   /";
            put_emphasis(emphasises_second_word, 1);
        }

        private void lb5_Click(object sender, EventArgs e)
        {
            lb5.Text = "   /";
            put_emphasis(emphasises_third_word, 0);
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            lb6.Text = "   /";
            put_emphasis(emphasises_third_word, 1);
        }

        private void lb7_Click(object sender, EventArgs e)
        {
            lb7.Text = "    /";
            put_emphasis(emphasises_third_word, 2);
        }

        private void lb8_Click(object sender, EventArgs e)
        {
            lb8.Text = "    /";
            put_emphasis(emphasises_fouth_word, 0);
        }

        private void lb9_Click(object sender, EventArgs e)
        {
            lb9.Text = "  /";
            put_emphasis(emphasises_fouth_word, 1);
        }

        private void lb10_Click(object sender, EventArgs e)
        {
            lb10.Text = "   /";
            put_emphasis(emphasises_fouth_word, 2);
        }

        private void lb11_Click(object sender, EventArgs e)
        {
            lb11.Text = "  /";
            put_emphasis(emphasises_fouth_word, 3);
        }

        private void dis_able(Button B)
        {
            B.Enabled = false;
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if (emphasises[1].Text == "    /" && emphasises[3].Text == "   /" && emphasises[5].Text == "   /" && emphasises[7].Text == "    /")
            {
                label3.Text = "Верно!";
                button2.Enabled = true;

                con.Open();
                string query = "UPDATE tbl_users SET russ = 1 WHERE username = '" + Form1.name + "' ";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                R.button1.BackColor = Color.Green;
                R.button1.Enabled = false;
                R.button2.Enabled = true;

                buttons = new List<Button> { R.button1, R.button2, R.button3, R.button4, R.button5, R.button6, R.button7, R.button8, R.button9, R.button10 };
                for (int i = 2; i <buttons.Count; i++)
                {
                    dis_able(buttons[i]);
                }
            }
            else
            {
                label3.Text = "Неверно, попробуйте ещё";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R.button2_Click(this, null);
        }
    }
}
