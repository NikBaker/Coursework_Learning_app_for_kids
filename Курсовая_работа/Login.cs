using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Курсовая_работа
{
    public partial class Login : Form
    {
        public Form1 f1;

        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration Reg = new Registration();
            Reg.log_1 = this;
            this.Hide();
            Reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)  // Событие нажатия на кнопку "Войти как ученик"
        {
            con.Open();
            // Проверяем, существует ли пользователь с введенными данными в базе данных
            string login = "SELECT * FROM tbl_users WHERE username= '" + textBox1.Text + "' and class = '" + textBox3.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)  // Если нашелся пользователь с введенным логином и классом
            {
                // Проверка хэша
                bool flag = true;
                string user = "SELECT password FROM tbl_users WHERE username = '" + textBox1.Text + "' ";
                cmd = new OleDbCommand(user, con);
                string savedPasswordHash = cmd.ExecuteScalar().ToString();
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                string enteredPsw = textBox2.Text;
                var pbkdf2 = new Rfc2898DeriveBytes(enteredPsw, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                    {
                        flag = false;
                        MessageBox.Show("Неправильно введен пароль", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        break;
                    }
                if (flag) // Если нашелся пользователь с таким паролем
                {
                    // скрытие этой формы и открытие главной формы
                    this.Hide();
                    f1.Enabled = true;
                    f1.WindowState = FormWindowState.Normal;
                    f1.label1.Text = textBox1.Text;
                    Form1.name = textBox1.Text;

                    // получаем из базы данных результаты данного пользователя и заносим их на главную фомру
                    string query = "SELECT russ FROM tbl_users WHERE username = '" + textBox1.Text + "' ";
                    cmd = new OleDbCommand(query, con);
                    f1.label6.Text = cmd.ExecuteScalar().ToString() + "/10";

                    string query2 = "SELECT math FROM tbl_users WHERE username = '" + textBox1.Text + "' ";
                    cmd = new OleDbCommand(query2, con);
                    f1.label5.Text = cmd.ExecuteScalar().ToString() + "/10";

                    string query3 = "SELECT game15 FROM tbl_users WHERE username = '" + textBox1.Text + "' ";
                    cmd = new OleDbCommand(query3, con);
                    f1.label2.Text = cmd.ExecuteScalar().ToString();

                    string query4 = "SELECT nature FROM tbl_users WHERE username = '" + textBox1.Text + "' ";
                    cmd = new OleDbCommand(query4, con);
                    f1.label9.Text = cmd.ExecuteScalar().ToString() + "/10";
                }
            }
            else // Если такого пользователя не существует
            {
                MessageBox.Show("Неправильно введен логин и/или класс", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + textBox1.Text + "' and password = '" + textBox2.Text + "' and class = '" + textBox3.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                // скрытие этой формы и открытие главной формы
                this.Hide();
                f1.Hide();

                Teacher_Form Teacher = new Teacher_Form();
                Teacher.label1.Text = textBox1.Text;
                Teacher.lblTitle.Text += textBox3.Text;
                Teacher.Show();

                // Получаем из базы данных всех учеников нужного класса и выводим их результаты
                string query4 = "SELECT username, russ, math, game15, nature FROM tbl_users WHERE class = '" + textBox3.Text + "' and isteacher = 0 ORDER BY username ";
                OleDbCommand cmd2 = new OleDbCommand(query4, con);
                OleDbDataReader reader = cmd2.ExecuteReader();

                Teacher.listBox1.Items.Clear();
                while (reader.Read())
                {
                    Teacher.listBox1.Items.Add(reader[0].ToString() + " | " /*+ "Кол-во выполненых номеров по русскому языку:"*/ + reader[1].ToString() + " | " /*+ "Кол-во выполненых номеров по математике:"*/ + reader[2].ToString() + " | "  /*+ "Кол-во выполненых номеров по окружающему миру:"*/ + reader[4].ToString() + " ");
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин и/или пароль", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            con.Close();
        }
    }
}
