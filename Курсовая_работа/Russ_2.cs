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
    public partial class Russ_2 : Form
    {
        public Russ R;
        List<Button> buttons;
        public Russ_2()
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

        private void button1_Click(object sender, EventArgs e) // Событие нажатие на кнопку "Ответить"
        {
            // Проверяем, что ученик правильно вставил все буквы в слова
            if (textBox1.Text == "е" && textBox2.Text == "е" && textBox3.Text == "о" && textBox4.Text == "я")
            {
                label10.Text = "Верно!";
                button2.Enabled = true;

                // Обновляем значение выполненных пользователем заданий по русскому языку в БД
                con.Open();
                string query = "UPDATE tbl_users SET russ = 2 WHERE username = '" + Form1.name + "' ";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                // Окрашиваем кнопку выполненного задания в зеленый цвет и делаем доступным следующее задание
                R.button2.BackColor = Color.Green;
                R.button3.Enabled = true;

                // остальные задания остаются недоступными
                buttons = new List<Button> { R.button1, R.button2, R.button3, R.button4, R.button5, R.button6, R.button7, R.button8, R.button9, R.button10 };
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (i != 2)
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
            R.button3_Click(this, null);
        }
    }
}
