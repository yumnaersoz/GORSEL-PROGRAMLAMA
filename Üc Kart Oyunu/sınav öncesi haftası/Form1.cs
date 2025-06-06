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

namespace sınav_öncesi_haftası
{
    public partial class Form1 : Form
    {
        bool issiyah = false;
        int TiklanmaSayisi = 0;
        int ilkTikIndex = 0;
        bool[] Konum = { false, false, false };
        int Toplam = 0;
        int KalanSayi = 10;
        string[] resimAd = { "", "", "" };



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OyunuTekrarBaslatRastgele();
            BTNOYUNUBASLAT.Visible = false;

        }
        public void OyunuTekrarBaslatRastgele()
        {
            issiyah = false;
            Random rnd = new Random();
            int Hangisayi = rnd.Next(1, 6);
            int Digersayi = Hangisayi;
            while (Digersayi == Hangisayi)
            {
                Digersayi = rnd.Next(1, 6);
            }

            int TekNo = rnd.Next(1, 4);
            if (TekNo == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Digersayi.ToString() + ".png";
                pictureBox2.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                pictureBox3.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                Konum[0] = false;
                Konum[1] = true;
                Konum[2] = true;
                resimAd[0] = Digersayi.ToString() + ".png";
                resimAd[1] = Hangisayi.ToString() + ".png";
                resimAd[2] = Hangisayi.ToString() + ".png";
            }
            else if (TekNo == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                pictureBox2.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Digersayi.ToString() + ".png";
                pictureBox3.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                Konum[0] = true;
                Konum[1] = false;
                Konum[2] = true;
                resimAd[0] = Hangisayi.ToString() + ".png";
                resimAd[1] = Digersayi.ToString() + ".png";
                resimAd[2] = Hangisayi.ToString() + ".png";

            }
            else
            {
                pictureBox1.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                pictureBox2.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Hangisayi.ToString() + ".png";
                pictureBox3.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + Digersayi.ToString() + ".png";
                Konum[0] = true;
                Konum[1] = true;
                Konum[2] = false;
                resimAd[0] = Hangisayi.ToString() + ".png";
                resimAd[1] = Hangisayi.ToString() + ".png";
                resimAd[2] = Digersayi.ToString() + ".png";

            }
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!issiyah)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\arka plan.png";
                pictureBox2.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\arka plan.png";
                pictureBox3.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\arka plan.png";

                issiyah = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if  (KalanSayi > 1)
            {
                KalanSayi--;
                lblzaman.Text = KalanSayi.ToString();
            }
            else if  (KalanSayi == 1)
            {
                KalanSayi--;
                lblzaman.Text = KalanSayi.ToString();
                MessageBox.Show("Süre Doldu");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                BTNOYUNUBASLAT.Visible = true;
                Toplam = 0;
                lblpuan.Text = Toplam.ToString();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + resimAd[0];
            issiyah = false;
            if (TiklanmaSayisi == 1)
            {
                DogruKontrol(1);
                TiklanmaSayisi = 0;
                ilkTikIndex = 0;
            }
            else
            {
                TiklanmaSayisi++;
                ilkTikIndex = 1;
            }

        }
       
       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            pictureBox2.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + resimAd[1];
            issiyah = false;
            if (TiklanmaSayisi == 1)
            {
                DogruKontrol(2);
                TiklanmaSayisi = 0;
                ilkTikIndex = 0;
            }
            else
            {
                TiklanmaSayisi++;
                ilkTikIndex = 2;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "C:\\Users\\yumna\\source\\repos\\sınav öncesi haftası\\sınav öncesi haftası\\img\\sayı " + resimAd[2];
            issiyah = false;
            if (TiklanmaSayisi == 1)
            {
                DogruKontrol(3);
                TiklanmaSayisi = 0;
                ilkTikIndex = 0;
            }
            else
            {
                TiklanmaSayisi++;
                ilkTikIndex = 3;
            }
        }
         public void DogruKontrol (int GondereIndex)
        {
            if (Konum[ilkTikIndex -1] && Konum[GondereIndex - 1])
            {
                timer2.Stop();
                Toplam = Toplam + KalanSayi;
                lblpuan.Text = Toplam.ToString();
                MessageBox.Show("Tebrikler Kazandınız");
                BTNYENİOYUN.Visible = true;
                KalanSayi = 10;
                lblzaman.Text = KalanSayi.ToString();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;

            }
            else
            {
                MessageBox.Show("Tekrar Deneyin");
            }

        }

        private void BTNYENİOYUN_Click(object sender, EventArgs e)
        {
            OyunuTekrarBaslatRastgele();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            BTNYENİOYUN.Visible = false;
            KalanSayi = 10;

        }
    }
 }

