using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_programlama_Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(txtvize.Text);
            int final = Convert.ToInt32(txtfinal.Text);
            double ortalama = (vize * 0.4) + (final * 0.6);
            string HarfNot = "";

            if (ortalama > 90)
            {
                HarfNot = "AA";
                

            }
            else if (ortalama > 85)
            {
                HarfNot = "BA";
            }
            else if (ortalama > 80)
            {
                HarfNot = "BB";
            }
            else if (ortalama > 70)
            {
                HarfNot = "CB";
            }
            else if (ortalama > 60)
            {
                HarfNot = "CC";
            }
            else if (ortalama > 55)
            {
                HarfNot = "DC";
            }
            else if (ortalama > 50)
            {
                HarfNot = "DD";
            }
            else 
            {
                HarfNot = "FF";
            }
            MessageBox.Show("HarfNotunuz = " + HarfNot+" ortalama :"+ortalama);

        }
    }
}
