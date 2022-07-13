using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Курсовая_работа
{
    public partial class Registration : Form
    {
        public Login log_1;
        public Registration()
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_1.Show();
        }

        private string SetHash()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            string password = textBox2.Text;
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        private void button2_Click(object sender, EventArgs e) // Событие нажатия на кнопку "Регистрация" 
        {
            // Если при нажатии на кнопку какие-то поля остались пустыми, выводим сообщение об ошибке
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка во время регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Если все поля заполнены и два поля с вводом пароля имеют одинаковые значения:
            else if (textBox2.Text == textBox3.Text)
            {
                // Добавляем нового пользователя в базу данных
                con.Open();
                if (checkBox1.Checked)
                {
                    // Сохраняем в бд не сам пароль, а его хэш
                    string HashPsw = SetHash();

                    string register = "INSERT INTO tbl_users VALUES('" + textBox1.Text + "','" + HashPsw + "', 0, 0, 999, 0, '" + textBox4.Text + "', 1)";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Сохраняем в бд не сам пароль, а его хэш
                    string HashPsw = SetHash();

                    string register = "INSERT INTO tbl_users VALUES('" + textBox1.Text + "','" + HashPsw + "', 0, 0, 999, 0, '" + textBox4.Text + "', 0)";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                }
                
                con.Close();

                MessageBox.Show("Вы успешно зарегистрировались", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка во время регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }
    }
}
