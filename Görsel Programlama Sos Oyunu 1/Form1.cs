using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Sos_Oyunu_1
{
    public partial class Form1 : Form
    {
        int SiraNo = 1;
        int[] Durum = { 0, 0, 0, 0, 0, 0, 0, 0, };
        int Puan1 = 0;
        int Puan2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            button12.Visible= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button1.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();

                    MessageBox.Show("1. Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button1.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2. Oyuncu 1 Puan Kazandı");
                }

            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button2.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();

                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button2.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {
                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button3.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button3.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button4.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button4.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button4.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button5.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button5.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button6.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button6.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button7.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button7.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button8.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {

                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button8.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (SiraNo == 1)
            {
                button9.Text = "X";
                SiraNo = 2;
                label2.Text = "Sıra 2. Oyuncuda";
                if (KontrolEt("X"))
                {
                    Puan1++;
                    txt1.Text = Puan1.ToString();
                    MessageBox.Show("1.Oyuncu 1 Puan Kazandı");
                }
            }
            else
            {
                button9.Text = "O";
                SiraNo = 1;
                label2.Text = "Sıra 1. Oyuncuda";
                if (KontrolEt("O"))
                {

                    Puan2++;
                    txt2.Text = Puan2.ToString();
                    MessageBox.Show("2.Oyuncu 1 Puan Kazandı");
                }
            }
            button9.Enabled = false;
        }

        public bool KontrolEt(string harf)
        {
            if (Durum[0] != 1 && button1.Text == harf && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                Durum[0] = 1;
                return true;
            }
            else if (Durum[1] != 1 && button4.Text == harf && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                Durum[1] = 1;
                return true;
            }
            else if (Durum[2] != 1 && button7.Text == harf && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                Durum[2] = 1;
                return true;
            }
            else if (Durum[3] != 1 && button1.Text == harf && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                Durum[3] = 1;
                return true;
            }
            else if (Durum[4] != 1 && button2.Text == harf && button2.Text == button5.Text && button2.Text == button8.Text)
            {
                Durum[4] = 1;
                return true;
            }
            else if (Durum[5] != 1 && button3.Text == harf && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                Durum[5] = 1;
                return true;
            }
            else if (Durum[6] != 1 && button1.Text == harf && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                Durum[6] = 1;
                return true;
            }
            else if (Durum[7] != 1 && button3.Text == harf && button3.Text == button5.Text && button3.Text == button7.Text)
            {
                Durum[7] = 1;
                return true;
            }
            return false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            YenidenBaşlat();
        }
        private void YenidenBaşlat()
        {
            Durum[0] = 0;
            Durum[1] = 0;
            Durum[2] = 0;
            Durum[3] = 0;
            Durum[4] = 0;
            Durum[5] = 0;
            Durum[6] = 0;
            Durum[7] = 0;
            Puan1 = 0;
            Puan2 = 0;




            // Butonları temizle
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // Butonları etkinleştir
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            label1.Text = "0";
            label3.Text = "0";
           
            // Sıra numarasını sıfırla
            SiraNo = 1;
            label2.Text = "Sıra 1. Oyuncuda";
        }
        private void GüncellePuanlar()
        {
            txt1.Text = "1. Oyuncu Puanı: " + Puan1;
            txt2.Text = "2. Oyuncu Puanı: " + Puan2;
        }

    }
}
    




