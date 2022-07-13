using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;
using System.Data.OleDb;

namespace Курсовая_работа
{
    public partial class Game_15 : Form
    {
        int k;  // количество шагов
        int win_k;  // количество верно стоящих картинок
        Timer tmr1, tmr2, tmr3, tmr4, tmr5, tmr6, tmr7, tmr8, tmr9;
        readonly List<PictureBox> Images;
        List<int> Right_Order;
        readonly List<Point> Locations;
        List<int> Random_Order;


        int k_15;
        int win_k_15;
        Timer tmr1_15, tmr2_15, tmr3_15, tmr4_15, tmr5_15, tmr6_15, tmr7_15, tmr8_15, tmr9_15, tmr10, tmr11, tmr12, tmr13, tmr14, tmr15, tmr16;
        readonly List<PictureBox> Images_15;
        List<int> Right_Order_15;
        readonly List<Point> Locations_15;
        List<int> Random_Order_15;


        public Game_15()
        {
            InitializeComponent();
            Point first_pos = im1.Location;
            Point second_pos = im2.Location;
            Point third_pos = im3.Location;
            Point fouth_pos = im4.Location;
            Point fifth_pos = im5.Location;
            Point sixth_pos = im6.Location;
            Point seventh_pos = im7.Location;
            Point eighth_pos = im8.Location;
            Point nineth_pos = im9.Location;


            Point first_pos_15 = pB1.Location;
            Point second_pos_15 = pB2.Location;
            Point third_pos_15 = pB3.Location;
            Point fouth_pos_15 = pB4.Location;
            Point fifth_pos_15 = pB5.Location;
            Point sixth_pos_15 = pB6.Location;
            Point seventh_pos_15 = pB7.Location;
            Point eighth_pos_15 = pB8.Location;
            Point nineth_pos_15 = pB9.Location;
            Point tenth_pos_15 = pB10.Location;
            Point eleventh_pos_15 = pB11.Location;
            Point tvelveth_pos_15 = pB12.Location;
            Point thirtinth_pos_15 = pB13.Location;
            Point foutinth_pos_15 = pB14.Location;
            Point fiftinth_pos_15 = pB15.Location;
            Point sixtinth_pos_15 = pB16.Location;

            k = 0;
            k_15 = 0;
            win_k = 0;
            win_k_15 = 0;
            Images = new List<PictureBox> { im1, im2, im3, im4, im5, im6, im7, im8, im9 };
            Images_15 = new List<PictureBox> { pB1, pB2, pB3, pB4, pB5, pB6, pB7, pB8, pB9, pB10, pB11, pB12, pB13, pB14, pB15, pB16 };

            Right_Order = new List<int> { 8, 3, 7, 1, 4, 2, 6, 0, 5 }; // <- для первой расстановки
            Random_Order = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Right_Order_15 = new List<int> { 4, 0, 7, 2, 1, 3, 11, 15, 8, 6, 10, 14, 12, 9, 13, 5}; // <- для первой расстановки
            Random_Order_15 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Locations = new List<Point> { first_pos, second_pos, third_pos, fouth_pos, fifth_pos, sixth_pos, seventh_pos, eighth_pos, nineth_pos };
            Locations_15 = new List<Point> { first_pos_15, second_pos_15, third_pos_15, fouth_pos_15, fifth_pos_15, sixth_pos_15, seventh_pos_15, eighth_pos_15, nineth_pos_15, tenth_pos_15, eleventh_pos_15, tvelveth_pos_15, thirtinth_pos_15, foutinth_pos_15, fiftinth_pos_15, sixtinth_pos_15 };

            tmr1 = new Timer();
            tmr1.Interval = 100;
            tmr1.Tick += Tmr_Tick1;

            tmr2 = new Timer();
            tmr2.Interval = 100;
            tmr2.Tick += Tmr_Tick2;

            tmr3 = new Timer();
            tmr3.Interval = 100;
            tmr3.Tick += Tmr_Tick3;

            tmr4 = new Timer();
            tmr4.Interval = 100;
            tmr4.Tick += Tmr_Tick4;

            tmr5 = new Timer();
            tmr5.Interval = 100;
            tmr5.Tick += Tmr_Tick5;

            tmr6 = new Timer();
            tmr6.Interval = 100;
            tmr6.Tick += Tmr_Tick6;

            tmr7 = new Timer();
            tmr7.Interval = 100;
            tmr7.Tick += Tmr_Tick7;

            tmr8 = new Timer();
            tmr8.Interval = 100;
            tmr8.Tick += Tmr_Tick8;

            tmr9 = new Timer();
            tmr9.Interval = 100;
            tmr9.Tick += Tmr_Tick9;

            ///////////////////////////////
            tmr1_15 = new Timer();
            tmr1_15.Interval = 50;
            tmr1_15.Tick += Tmr_Tick1_15;

            tmr2_15 = new Timer();
            tmr2_15.Interval = 50;
            tmr2_15.Tick += Tmr_Tick2_15;
            
            tmr3_15 = new Timer();
            tmr3_15.Interval = 50;
            tmr3_15.Tick += Tmr_Tick3_15;

            tmr4_15 = new Timer();
            tmr4_15.Interval = 50;
            tmr4_15.Tick += Tmr_Tick4_15;

            tmr5_15 = new Timer();
            tmr5_15.Interval = 50;
            tmr5_15.Tick += Tmr_Tick5_15;

            tmr6_15 = new Timer();
            tmr6_15.Interval = 50;
            tmr6_15.Tick += Tmr_Tick6_15;

            tmr7_15 = new Timer();
            tmr7_15.Interval = 50;
            tmr7_15.Tick += Tmr_Tick7_15;

            tmr8_15 = new Timer();
            tmr8_15.Interval = 50;
            tmr8_15.Tick += Tmr_Tick8_15;

            tmr9_15 = new Timer();
            tmr9_15.Interval = 50;
            tmr9_15.Tick += Tmr_Tick9_15;

            tmr10 = new Timer();
            tmr10.Interval = 50;
            tmr10.Tick += Tmr_Tick10_15;

            tmr11 = new Timer();
            tmr11.Interval = 50;
            tmr11.Tick += Tmr_Tick11_15;

            tmr12 = new Timer();
            tmr12.Interval = 50;
            tmr12.Tick += Tmr_Tick12_15;

            tmr13 = new Timer();
            tmr13.Interval = 50;
            tmr13.Tick += Tmr_Tick13_15;

            tmr14 = new Timer();
            tmr14.Interval = 50;
            tmr14.Tick += Tmr_Tick14_15;

            tmr15 = new Timer();
            tmr15.Interval = 50;
            tmr15.Tick += Tmr_Tick15_15;

            tmr16 = new Timer();
            tmr16.Interval = 50;
            tmr16.Tick += Tmr_Tick16_15;

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private bool Random(int pos)
        {

            var rnd = new Random();
            var i1 = rnd.Next(9);

            Random_Order[pos] = i1;

            Images[pos].Location = Locations[i1];

            if (Random_Order[pos] == Right_Order[pos] )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool Random_15(int pos)
        {
            var rnd = new Random();
            var i1 = rnd.Next(16);

            Random_Order_15[pos] = i1;

            Images_15[pos].Location = Locations_15[i1];

            if (Random_Order_15[pos] == Right_Order_15[pos])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Tmr_Tick1(object sender, EventArgs e)
        {            
            if (Random(0))
            {
                tmr1.Stop();
            }
        }

        private void Tmr_Tick2(object sender, EventArgs e)
        {
            if (Random(1))
            {
                tmr2.Stop();
            }
        }

        private void Tmr_Tick3(object sender, EventArgs e)
        {
            if (Random(2))
            {
                tmr3.Stop();
            }
        }

        private void Tmr_Tick4(object sender, EventArgs e)
        {
            if (Random(3))
            {
                tmr4.Stop();
            }
        }

        private void Tmr_Tick5(object sender, EventArgs e)
        {
            if (Random(4))
            {
                tmr5.Stop();
            }
        }

        private void Tmr_Tick6(object sender, EventArgs e)
        {
            if (Random(5))
            {
                tmr6.Stop();
            }
        }

        private void Tmr_Tick7(object sender, EventArgs e)
        {
            if (Random(6))
            {
                tmr7.Stop();
            }
        }

        private void Tmr_Tick8(object sender, EventArgs e)
        {
            if (Random(7))
            {
                tmr8.Stop();
            }
        }

        private void Tmr_Tick9(object sender, EventArgs e)
        {
            if (Random(8))
            {
                tmr9.Stop();
            }
        }


        /////////////////////
        private void Tmr_Tick1_15(object sender, EventArgs e)
        {
            if (Random_15(0))
            {
                tmr1_15.Stop();
            }
        }

        private void Tmr_Tick2_15(object sender, EventArgs e)
        {
            if (Random_15(1))
            {
                tmr2_15.Stop();
            }
        }

        private void Tmr_Tick3_15(object sender, EventArgs e)
        {
            if (Random_15(2))
            {
                tmr3_15.Stop();
            }
        }

        private void Tmr_Tick4_15(object sender, EventArgs e)
        {
            if (Random_15(3))
            {
                tmr4_15.Stop();
            }
        }

        private void Tmr_Tick5_15(object sender, EventArgs e)
        {
            if (Random_15(4))
            {
                tmr5_15.Stop();
            }
        }

        private void Tmr_Tick6_15(object sender, EventArgs e)
        {
            if (Random_15(5))
            {
                tmr6_15.Stop();
            }
        }

        private void Tmr_Tick7_15(object sender, EventArgs e)
        {
            if (Random_15(6))
            {
                tmr7_15.Stop();
            }
        }

        private void Tmr_Tick8_15(object sender, EventArgs e)
        {
            if (Random_15(7))
            {
                tmr8_15.Stop();
            }
        }

        private void Tmr_Tick9_15(object sender, EventArgs e)
        {
            if (Random_15(8))
            {
                tmr9_15.Stop();
            }
        }

        private void Tmr_Tick10_15(object sender, EventArgs e)
        {
            if (Random_15(9))
            {
                tmr10.Stop();
            }
        }

        private void Tmr_Tick11_15(object sender, EventArgs e)
        {
            if (Random_15(10))
            {
                tmr11.Stop();
            }
        }

        private void Tmr_Tick12_15(object sender, EventArgs e)
        {
            if (Random_15(11))
            {
                tmr12.Stop();
            }
        }

        private void Tmr_Tick13_15(object sender, EventArgs e)
        {
            if (Random_15(12))
            {
                tmr13.Stop();
            }
        }

        private void Tmr_Tick14_15(object sender, EventArgs e)
        {
            if (Random_15(13))
            {
                tmr14.Stop();
            }
        }        

        private void Tmr_Tick15_15(object sender, EventArgs e)
        {
            if (Random_15(14))
            {
                tmr15.Stop();
            }
        }

        private void Tmr_Tick16_15(object sender, EventArgs e)
        {
            if (Random_15(15))
            {
                tmr16.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            im1.Visible = true;
            im2.Visible = true;
            im3.Visible = true;
            im4.Visible = true;
            im5.Visible = true;
            im6.Visible = true;
            im7.Visible = true;
            im8.Visible = true;
            im9.Visible = true;

            button3.Visible = true;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pB1.Visible = true;
            pB2.Visible = true;
            pB3.Visible = true;
            pB4.Visible = true;
            pB5.Visible = true;
            pB6.Visible = true;
            pB7.Visible = true;
            pB8.Visible = true;
            pB9.Visible = true;
            pB10.Visible = true;
            pB11.Visible = true;
            pB12.Visible = true;
            pB13.Visible = true;
            pB14.Visible = true;
            pB15.Visible = true;
            pB16.Visible = true;

            button4.Visible = true;
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var number_of_game = rand.Next(1, 4);
            if (number_of_game == 1)
            {
                Right_Order = new List<int> { 8, 3, 7, 1, 4, 2, 6, 0, 5 };
            }
            if (number_of_game == 2)
            {
                Right_Order = new List<int> { 1, 5, 8, 4, 0, 6, 3, 2, 7 };
            }
            if (number_of_game == 3)
            {
                Right_Order = new List<int> { 5, 4, 3, 6, 1, 8, 7, 2, 0 };
            }

            Num_of_steps.Text = "";
            Win_label.Text = "";
            k = 0;
            win_k = 0;
            tmr1.Start();
            tmr2.Start();
            tmr3.Start();
            tmr4.Start();
            tmr5.Start();
            tmr6.Start();
            tmr7.Start();
            tmr8.Start();
            tmr9.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var number_of_game = rand.Next(1, 4);
            if (number_of_game == 1)
            {
                Right_Order_15 = new List<int> { 4, 0, 7, 2, 1, 3, 11, 15, 8, 6, 10, 14, 12, 9, 13, 5 };
            }
            if (number_of_game == 2)
            {
                Right_Order_15 = new List<int> { 5, 9, 2, 3, 1, 8, 6, 7, 12, 4, 13, 10, 14, 15, 11, 0  };
            }
            if (number_of_game == 3)
            {
                Right_Order_15 = new List<int> { 0, 2, 6, 3, 4, 1, 7, 11, 9, 5, 10, 15, 8, 12, 14, 13 };
            }

            Num_of_steps_15.Text = "";
            Win_label_15.Text = "";
            k_15 = 0;
            win_k_15 = 0;
            tmr1_15.Start();
            tmr2_15.Start();
            tmr3_15.Start();
            tmr4_15.Start();
            tmr5_15.Start();
            tmr6_15.Start();
            tmr7_15.Start();
            tmr8_15.Start();
            tmr9_15.Start();
            tmr10.Start();
            tmr11.Start();
            tmr12.Start();
            tmr13.Start();
            tmr14.Start();
            tmr15.Start();
            tmr16.Start();
        }

        private void Change_im(PictureBox im)
        {
            if (im.Location.X == im9.Location.X || im.Location.Y == im9.Location.Y) // Проверяем, стоит ли эта картинка в той же строке или в том же столбце, что и пустое поле
            {
                if (MathF.Abs(im.Location.X - im9.Location.X) == 106 || MathF.Abs(im.Location.Y - im9.Location.Y) == 106) // Проверяем, что эта ближайшая к пустому полю картинка(106 - расстояние между ближ. картинками)
                {
                    Point temp = new Point(im.Location.X, im.Location.Y);
                    im.Location = im9.Location;
                    im9.Location = temp;

                    k++; // Обновляем количество шагов
                    Num_of_steps.Text = Convert.ToString(k);

                    for (int i = 0; i < 9; i++)  // Считаем, сколько картинок стоит на нужных позициях
                    {
                        if (Images[i].Location != Locations[i])
                        {
                            win_k = 0;
                            break;
                        }
                        else
                        {
                            win_k++;
                        }
                    }
                }
            }
            if (win_k == 9) // Если все картинки стоят на нужных позициях, то игрок победил
            {
                Win_label.Text = "Победа!!!";

                con.Open();
                string query = "UPDATE tbl_users SET game15 = '"+k+"' WHERE username = '" + Form1.name + "' ";
                cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Change_pB(PictureBox pb)
        {
            if (pb.Location.X == pB16.Location.X || pb.Location.Y == pB16.Location.Y) // Проверяем, стоит ли эта картинка в той же строке или в том же столбце, что и пустое поле
            {
                if (MathF.Abs(pb.Location.X - pB16.Location.X) == 106 || MathF.Abs(pb.Location.Y - pB16.Location.Y) == 106) // Проверяем, что эта ближайшая к пустому полю картинка(106 - расстояние между ближ. картинками)
                {
                    Point temp = new Point(pb.Location.X, pb.Location.Y);
                    pb.Location = pB16.Location;
                    pB16.Location = temp;

                    k_15++; // Обновляем количество шагов
                    Num_of_steps_15.Text = Convert.ToString(k_15);

                    for (int i = 0; i < 16; i++)  // Считаем, сколько картинок стоит на нужных позициях
                    {
                        if (Images_15[i].Location != Locations_15[i])
                        {
                            win_k_15 = 0;
                            break;
                        }
                        else
                        {
                            win_k_15++;
                        }
                    }
                }
            }
            if (win_k_15 == 16) // Если все картинки стоят на нужных позициях, то игрок победил
            {
                Win_label_15.Text = "Победа!!!";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)  //
        {
        }

        private void im1_Click(object sender, EventArgs e)
        {
            Change_im(im1);           
        }

        private void im2_Click(object sender, EventArgs e)
        {
            Change_im(im2);
        }

        private void im3_Click(object sender, EventArgs e)
        {
            Change_im(im3);
        }

        private void im4_Click(object sender, EventArgs e)
        {
            Change_im(im4);
        }

        private void im5_Click(object sender, EventArgs e)
        {
            Change_im(im5);
        }

        private void im6_Click(object sender, EventArgs e)
        {
            Change_im(im6);            
        }

        private void im7_Click(object sender, EventArgs e)
        {
            Change_im(im7);            
        }

        private void im8_Click(object sender, EventArgs e)
        {
            Change_im(im8);          
        }

        /////////////////

        private void pB1_Click(object sender, EventArgs e)
        {
            Change_pB(pB1);
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            Change_pB(pB2);
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            Change_pB(pB3);
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            Change_pB(pB4);
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            Change_pB(pB5);
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            Change_pB(pB6);
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            Change_pB(pB7);
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            Change_pB(pB8);
        }

        private void pB9_Click(object sender, EventArgs e)
        {
            Change_pB(pB9);
        }

        private void pB10_Click(object sender, EventArgs e)
        {
            Change_pB(pB10);
        }

        private void pB11_Click(object sender, EventArgs e)
        {
            Change_pB(pB11);
        }

        private void pB12_Click(object sender, EventArgs e)
        {
            Change_pB(pB12);
        }

        private void pB13_Click(object sender, EventArgs e)
        {
            Change_pB(pB13);
        }

        private void pB14_Click(object sender, EventArgs e)
        {
            Change_pB(pB14);
        }

        private void pB15_Click(object sender, EventArgs e)
        {
            Change_pB(pB15);
        }

    }
}
