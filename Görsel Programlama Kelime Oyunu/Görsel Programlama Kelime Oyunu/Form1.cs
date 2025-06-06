using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Kelime_Oyunu
{
    public partial class Form1 : Form
    {

        char[] soruHarfleri = new char[5];
        int AlinanHarf = 0;
        int DogruBilinenHarfSayisi = 0;
        int ToplamSkor = 0;
        Boolean[] Bulunmadimi = { true, true, true, true, true };
        bool HarfAlmaAktif = false;
        int Sorulacakindex = 0;
        List<string> SorulacakKelimeler = new List<string> { "DÜNYA", "SEVGİ", "HAYAT", "İNSAN", "ÇİÇEK", "BAHAR", };






        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                return;
            }
            else if (HarfAlmaAktif)
            {
                HarfAlmaAktif = false;
                if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                {
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                    label6.Text = ToplamSkor.ToString();
                    MessageBox.Show("Tebrikler Oyunu Kazandınız");
                    AlinanHarf = 0;
                    DogruBilinenHarfSayisi = 0;

                    OyunNext();
                    return;

                    //Tamamlanacak
                }
                return;
            }
            else if (textBox3.Text.Length == 1)
            {
                //Girilen Harf Doğrumu kontrol mekanizması
                char[] Harfim = textBox3.Text.ToUpper().ToCharArray();
                if (soruHarfleri[2] == Harfim[0])
                {
                    DogruBilinenHarfSayisi++;
                    if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                    {
                        label4.Text = DogruBilinenHarfSayisi.ToString();
                        ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                        label6.Text = ToplamSkor.ToString();
                        MessageBox.Show("Tebrikler Oyunu Kazandınız");
                        AlinanHarf = 0;
                        DogruBilinenHarfSayisi = 0;

                        OyunNext();
                        return;
                        //Tamamlanacak
                    }
                    textBox3.Enabled = false;
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    Bulunmadimi[0] = false;
                }
                else
                {
                    MessageBox.Show("Girilen Harf Yanlış");
                    textBox3.Text = "";
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
            {
                return;
            }
            else if (HarfAlmaAktif)
            {
                HarfAlmaAktif = false;
                if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                {
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                    label6.Text = ToplamSkor.ToString();
                    MessageBox.Show("Tebrikler Oyunu Kazandınız");
                    AlinanHarf = 0;
                    DogruBilinenHarfSayisi = 0;

                    OyunNext();
                    return;

                    //Tamamlanacak
                }
                return;
            }
            else if (textBox5.Text.Length == 1)
            {
                //Girilen Harf Doğrumu kontrol mekanizması
                char[] Harfim = textBox5.Text.ToUpper().ToCharArray();
                if (soruHarfleri[4] == Harfim[0])
                {
                    DogruBilinenHarfSayisi++;
                    if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                    {
                        label4.Text = DogruBilinenHarfSayisi.ToString();
                        ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                        label6.Text = ToplamSkor.ToString();
                        MessageBox.Show("Tebrikler Oyunu Kazandınız");
                        AlinanHarf = 0;
                        DogruBilinenHarfSayisi = 0;

                        OyunNext();
                        return;
                        //Tamamlanacak
                    }
                    textBox5.Enabled = false;
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    Bulunmadimi[0] = false;
                }
                else
                {
                    MessageBox.Show("Girilen Harf Yanlış");
                    textBox5.Text = "";
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            Random rnd = new Random();
            Sorulacakindex = rnd.Next(0, SorulacakKelimeler.Count);
            soruHarfleri = SorulacakKelimeler[Sorulacakindex].ToCharArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            else if (HarfAlmaAktif)
            {
                HarfAlmaAktif = false;
                if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                {
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                    label6.Text = ToplamSkor.ToString();
                    MessageBox.Show("Tebrikler Oyunu Kazandınız");
                    AlinanHarf = 0;
                    DogruBilinenHarfSayisi = 0;

                    OyunNext();
                    return;

                    //Tamamlanacak
                }
                return;
            }
            else if (textBox1.Text.Length == 1)
            {
                //Girilen Harf Doğrumu kontrol mekanizması
                char[] Harfim = textBox1.Text.ToUpper().ToCharArray();
                if (soruHarfleri[0] == Harfim[0])
                {
                    DogruBilinenHarfSayisi++;
                    if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                    {
                        label4.Text = DogruBilinenHarfSayisi.ToString();
                        ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                        label6.Text = ToplamSkor.ToString();
                        MessageBox.Show("Tebrikler Oyunu Kazandınız");
                        AlinanHarf = 0;
                        DogruBilinenHarfSayisi = 0;

                        OyunNext();
                        return;
                        //Tamamlanacak
                    }
                    textBox1.Enabled = false;
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    Bulunmadimi[0] = false;
                }
                else
                {
                    MessageBox.Show("Girilen Harf Yanlış");
                    textBox1.Text = "";
                }
            }
        }
        public void OyunNext()
        {
            if (ToplamSkor >= 10)
            {
                MessageBox.Show("Tebrikler Oyunu Bitirdiniz");
                this.Close();
            }
            SorulacakKelimeler.RemoveAt(Sorulacakindex);
            Random rnd = new Random();
            Sorulacakindex = rnd.Next(0, SorulacakKelimeler.Count);
            soruHarfleri = SorulacakKelimeler[Sorulacakindex].ToCharArray();
            Bulunmadimi[0] = true;
            Bulunmadimi[1] = true;
            Bulunmadimi[2] = true;
            Bulunmadimi[3] = true;
            Bulunmadimi[4] = true;
            textBox1.Text = "";
            textBox1.Enabled = true;

            textBox2.Text = "";
            textBox2.Enabled = true;

            textBox3.Text = "";
            textBox3.Enabled = true;

            textBox4.Text = "";
            textBox4.Enabled = true;

            textBox5.Text = "";
            textBox5.Enabled = true;

            label2.Text = "3";
            label4.Text = "0";






        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                return;
            }
            else if (HarfAlmaAktif)
            {
                HarfAlmaAktif = false;
                if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                {
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                    label6.Text = ToplamSkor.ToString();
                    MessageBox.Show("Tebrikler Oyunu Kazandınız");
                    AlinanHarf = 0;
                    DogruBilinenHarfSayisi = 0;

                    OyunNext();
                    return;

                    //Tamamlanacak
                }
                return;
            }
            else if (textBox2.Text.Length == 1)
            {
                //Girilen Harf Doğrumu kontrol mekanizması
                char[] Harfim = textBox2.Text.ToUpper().ToCharArray();
                if (soruHarfleri[1] == Harfim[0])
                {
                    DogruBilinenHarfSayisi++;
                    if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                    {
                        label4.Text = DogruBilinenHarfSayisi.ToString();
                        ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                        label6.Text = ToplamSkor.ToString();
                        MessageBox.Show("Tebrikler Oyunu Kazandınız");
                        AlinanHarf = 0;
                        DogruBilinenHarfSayisi = 0;

                        OyunNext();
                        return;
                        //Tamamlanacak
                    }
                    textBox2.Enabled = false;
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    Bulunmadimi[1] = false;
                }
                else
                {
                    MessageBox.Show("Girilen Harf Yanlış");
                    textBox2.Text = "";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                return;
            }
            else if (HarfAlmaAktif)
            {
                HarfAlmaAktif = false;
                if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                {
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                    label6.Text = ToplamSkor.ToString();
                    MessageBox.Show("Tebrikler Oyunu Kazandınız");
                    AlinanHarf = 0;
                    DogruBilinenHarfSayisi = 0;

                    OyunNext();
                    return;

                    //Tamamlanacak
                }
                return;
            }
            else if (textBox4.Text.Length == 1)
            {
                //Girilen Harf Doğrumu kontrol mekanizması
                char[] Harfim = textBox4.Text.ToUpper().ToCharArray();
                if (soruHarfleri[3] == Harfim[0])
                {
                    DogruBilinenHarfSayisi++;
                    if ((DogruBilinenHarfSayisi + AlinanHarf) == 5)
                    {
                        label4.Text = DogruBilinenHarfSayisi.ToString();
                        ToplamSkor = ToplamSkor + DogruBilinenHarfSayisi;
                        label6.Text = ToplamSkor.ToString();
                        MessageBox.Show("Tebrikler Oyunu Kazandınız");
                        AlinanHarf = 0;
                        DogruBilinenHarfSayisi = 0;

                        OyunNext();
                        return;
                        //Tamamlanacak
                    }
                    textBox4.Enabled = false;
                    label4.Text = DogruBilinenHarfSayisi.ToString();
                    Bulunmadimi[3] = false;
                }
                else
                {
                    MessageBox.Show("Girilen Harf Yanlış");
                    textBox4.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AlinanHarf < 3)
            {
                Random rnd = new Random();
                bool devam = true;
                while (devam)
                {
                    int VerilecekNo = rnd.Next(0, 5);
                    if (Bulunmadimi[VerilecekNo])
                    {
                        devam = false;
                        if (VerilecekNo == 0)
                        {
                            AlinanHarf++;
                            HarfAlmaAktif = true;
                            textBox1.Text = soruHarfleri[0].ToString();
                            textBox1.Enabled = false;
                            Bulunmadimi[0] = false;

                        }
                        else if (VerilecekNo == 1)
                        {
                            AlinanHarf++;
                            HarfAlmaAktif = true;
                            textBox2.Text = soruHarfleri[1].ToString();
                            textBox2.Enabled = false;
                            Bulunmadimi[1] = false;
                        }
                        else if (VerilecekNo == 2)
                        {
                            AlinanHarf++;
                            HarfAlmaAktif = true;
                            textBox3.Text = soruHarfleri[2].ToString();
                            textBox3.Enabled = false;
                            Bulunmadimi[2] = false;
                        }
                        else if (VerilecekNo == 3)
                        {
                            AlinanHarf++;
                            HarfAlmaAktif = true;
                            textBox4.Text = soruHarfleri[3].ToString();
                            textBox4.Enabled = false;
                            Bulunmadimi[3] = false;
                        }
                        else if (VerilecekNo == 4)
                        {
                            AlinanHarf++;
                            HarfAlmaAktif = true;
                            textBox5.Text = soruHarfleri[4].ToString();
                            textBox5.Enabled = false;
                            Bulunmadimi[4] = false;
                        }


                    }
                    label2.Text = (3 - AlinanHarf).ToString();


                } 
            }
            else
            {
                MessageBox.Show("Harf Alma Hakkınız Kalmadı");
            }

        }

    }

   
}




