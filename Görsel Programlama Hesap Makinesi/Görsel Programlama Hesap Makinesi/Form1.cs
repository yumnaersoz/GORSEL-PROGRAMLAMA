using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        int Sayi1 = 0;
        int Sayi2 = 0;
        string Operatorum = "";
        bool OperatorAktif = false;
        bool Sayi1Aktif = false;
        bool Sayi2Aktif = false;
        bool sayi25Start = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!OperatorAktif)
            {
                txtAlan.Text += "1";
            }
            else
            {
                txtAlan.Text += "1";
                sayi25Start = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "2";
            }
            else
            {
                txtAlan.Text += "2";
                sayi25Start = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "3";
            }
            else
            {
                txtAlan.Text += "3";
                sayi25Start = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "4";
            }
            else
            {
                txtAlan.Text += "4";
                sayi25Start = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "5";
            }
            else
            {
                txtAlan.Text += "5";
                sayi25Start = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "6";
            }
            else
            {
                txtAlan.Text += "6";
                sayi25Start = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "7";
            }
            else
            {
                txtAlan.Text += "7";
                sayi25Start = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "8";
            }
            else
            {
                txtAlan.Text += "8";
                sayi25Start = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "9";
            }
            else
            {
                txtAlan.Text += "9";
                sayi25Start = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (!OperatorAktif)
            {
                txtAlan.Text += "0";
            }
            else
            {
                txtAlan.Text += "0";
                sayi25Start = true;
            }
        }

        public void Hesap(string operatorum)
        {
            if (txtAlan.Text != "")
            {
                if (!Sayi1Aktif)
                {
                    Sayi1 = Convert.ToInt32(txtAlan.Text);
                    Operatorum = operatorum;
                    Sayi1Aktif = true;
                    OperatorAktif = true;
                    txtAlan.Text += operatorum;
                }
                else if (OperatorAktif && sayi25Start)
                {
                    int sonuc = 0;
                    string[] Sayilarim = txtAlan.Text.Split(Operatorum[0]);
                    if (Sayilarim.Length > 0)
                    {
                        Sayi2 = Convert.ToInt32(Sayilarim[1]);
                        if (Operatorum == "+")
                        {
                            sonuc = Sayi1 + Sayi2;
                        }
                        else if (Operatorum == "-")
                        {
                            sonuc = Sayi1 - Sayi2;
                        }
                        else if (Operatorum == "*")
                        {

                            sonuc = Sayi1 * Sayi2;

                        }

                        else if (Operatorum == "/")
                        {

                            sonuc = Sayi1 / Sayi2;
                        }  

                        Sayi1 = sonuc;
                        Sayi2Aktif = false;
                        sayi25Start = false;
                        Operatorum = operatorum;
                        Sayi2 = 0;
                        txtAlan.Text = Sayi1 + operatorum;
                        
                    }
                     
                }
                else if (OperatorAktif && !Sayi2Aktif && !sayi25Start)
                {
                    Operatorum = operatorum;
                    txtAlan.Text = txtAlan.Text.Substring(0, txtAlan.Text.Length - 1);
                    txtAlan.Text += operatorum;
                }
                else
                {
                    Operatorum = operatorum;
                    Sayi1Aktif = true;
                    OperatorAktif = true;
                    txtAlan.Text += operatorum;

                }
            }
         
         
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            Hesap("+");

        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            Hesap("-");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Hesap("/");
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            Hesap("");
            OperatorAktif = false;
            Operatorum = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtAlan.Text = null;
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            Hesap("*");
        }
    }
}



    
    
    
    
    

