using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;



namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        static public string name; // Логин

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public Form1()
        {
            InitializeComponent();

            this.Enabled = false;
            this.WindowState = FormWindowState.Minimized;

            Login Log_in = new Login();
            Log_in.f1 = this;
            Log_in.Show();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = ButHome.Height;
            pnlNav.Top = ButHome.Top;
            pnlNav.Left = ButHome.Left;
            ButHome.BackColor = Color.FromArgb(46, 51, 73);           

            lblTitle.Text = "Главная";
            
            this.PnlFormLoader.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Before_show(Button b, bool flag)
        {
            this.PnlFormLoader.Visible = !flag;

            panel3.Visible = flag;
            panel4.Visible = flag;
            panel5.Visible = flag;
            panel6.Visible = flag;
            label2.Visible = flag;
            label3.Visible = flag;
            label4.Visible = flag;
            label5.Visible = flag;
            label6.Visible = flag;
            label7.Visible = flag;
            label8.Visible = flag;
            label9.Visible = flag;
            label10.Visible = flag;
            label11.Visible = flag;
            label12.Visible = flag;
            label13.Visible = flag;

            pnlNav.Height = b.Height;
            pnlNav.Top = b.Top;
            pnlNav.Left = b.Left;
            b.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void ButHome_Click(object sender, EventArgs e)
        {
            Before_show(ButHome, true);

            lblTitle.Text = "Главная";
            con.Open();
            string query = "SELECT russ FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query, con);
            label6.Text = cmd.ExecuteScalar().ToString() + "/10";

            string query2 = "SELECT math FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query2, con);
            label5.Text = cmd.ExecuteScalar().ToString() + "/10";

            string query3 = "SELECT game15 FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query3, con);
            label2.Text = cmd.ExecuteScalar().ToString();

            string query4 = "SELECT nature FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query4, con);
            label9.Text = cmd.ExecuteScalar().ToString() + "/10";

            con.Close();
        }

        private void SetButtons(int position, List<Button> but_list)
        {
            for (int i = 0; i < but_list.Count(); i++)
            {
                if (i < position)
                {
                    but_list[i].BackColor = Color.Green;
                    but_list[i].Enabled = false;
                }
                if (i > position)
                {
                    but_list[i].Enabled = false;
                }
            }
        }

        private void ButRuss_Click(object sender, EventArgs e)
        {
            Before_show(ButRuss, false);
            
            lblTitle.Text = "Русский язык";
            this.PnlFormLoader.Controls.Clear();
            Russ Russ_Vrb = new Russ() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Russ_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Russ_Vrb);
            Russ_Vrb.Show();

            con.Open();
            string query2 = "SELECT russ FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query2, con);

            int pos;
            pos = (int)cmd.ExecuteScalar();

            List<Button> butts = new List<Button> { Russ_Vrb.button1, Russ_Vrb.button2, Russ_Vrb.button3, Russ_Vrb.button4, Russ_Vrb.button5, Russ_Vrb.button6, Russ_Vrb.button7, Russ_Vrb.button8, Russ_Vrb.button9, Russ_Vrb.button10 };

            SetButtons(pos, butts);
           
            con.Close();
        }

        private void But_Math_Click(object sender, EventArgs e)
        {
            Before_show(But_Math, false);

            lblTitle.Text = "Математика";
            this.PnlFormLoader.Controls.Clear();
            Math Math_Vrb = new Math() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Math_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Math_Vrb);
            Math_Vrb.Show();

            con.Open();
            string query2 = "SELECT math FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query2, con);

            int pos;
            pos = (int)cmd.ExecuteScalar();

            List<Button> butts = new List<Button> { Math_Vrb.button1, Math_Vrb.button2, Math_Vrb.button3, Math_Vrb.button4, Math_Vrb.button5, Math_Vrb.button6, Math_Vrb.button7, Math_Vrb.button8, Math_Vrb.button9, Math_Vrb.button10 };

            SetButtons(pos, butts);

            con.Close();
        }

        private void But_Nature_Click(object sender, EventArgs e)
        {
            Before_show(But_Nature, false);

            lblTitle.Text = "Окружающий мир";
            this.PnlFormLoader.Controls.Clear();
            Nature Nature_Vrb = new Nature() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Nature_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Nature_Vrb);
            Nature_Vrb.Show();

            con.Open();
            string query2 = "SELECT nature FROM tbl_users WHERE username = '" + name + "' ";
            cmd = new OleDbCommand(query2, con);

            int pos;
            pos = (int)cmd.ExecuteScalar(); //

            List<Button> butts = new List<Button> { Nature_Vrb.button1, Nature_Vrb.button2, Nature_Vrb.button3, Nature_Vrb.button4, Nature_Vrb.button5, Nature_Vrb.button6, Nature_Vrb.button7, Nature_Vrb.button8, Nature_Vrb.button9, Nature_Vrb.button10 };

            SetButtons(pos, butts);

            con.Close();
        }

        private void But_15_Click(object sender, EventArgs e)
        {
            Before_show(But_15, false);

            lblTitle.Text = "Пятнашки";
            this.PnlFormLoader.Controls.Clear();
            Game_15 Game_15_Vrb = new Game_15() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Game_15_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Game_15_Vrb);
            Game_15_Vrb.Show();
        }

        private void ButSettings_Click(object sender, EventArgs e)
        {
            Before_show(ButSettings, false);
            
            lblTitle.Text = "Настройки";
            this.PnlFormLoader.Controls.Clear();
            Settings Settings_Vrb = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Settings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Settings_Vrb);
            Settings_Vrb.Show();
        }

        private void ButHome_Leave(object sender, EventArgs e)
        {
            ButHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ButRuss_Leave(object sender, EventArgs e)
        {
            ButRuss.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ButSettings_Leave(object sender, EventArgs e)
        {
            ButSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void But_Nature_Leave(object sender, EventArgs e)
        {
            But_Nature.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void But_Math_Leave(object sender, EventArgs e)
        {
            But_Math.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void But_15_Leave(object sender, EventArgs e)
        {
            But_15.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
