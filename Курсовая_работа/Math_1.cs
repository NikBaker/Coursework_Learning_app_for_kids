﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсовая_работа
{
    public partial class Math_1 : Form
    {
        public Math M;
        List<Button> buttons;
        public Math_1()
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
            // Если ученик правильно ответил на все примеры
            if (textBox1.Text == "13" && textBox2.Text == "29" && textBox3.Text == "41" && textBox4.Text == "144")
            {
                label10.Text = "Верно!";
                button2.Enabled = true;

                // Обновляем значение выполненных учеником заданий по математике в БД
                con.Open();
                string query = "UPDATE tbl_users SET math = 1 WHERE username = '" + Form1.name + "' ";
                cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                // Окрашиваем кнопку выполненного задания в зеленый цвет и делаем доступным следующее задание
                M.button1.BackColor = Color.Green;
                M.button2.Enabled = true;

                // остальные задания остаются недоступными
                buttons = new List<Button> { M.button1, M.button2, M.button3, M.button4, M.button5, M.button6, M.button7, M.button8, M.button9, M.button10 };
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
            M.button2_Click(this, null);
        }
    }
}
