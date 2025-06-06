using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şişe_Oyunu
{
    public partial class Form1 : Form
    {
        int sayac = 4;
        public Form1()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Image dondur = pictureBox1.Image;
            dondur.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = dondur;
            sayac++;
            Random rnd = new Random();
            int sayi = rnd.Next(0, 10);

            if (sayi == 3)
            {
                if (sayac % 4 == 0)
                {
                    lblmessaj.Text = txtoyuncu4 + "Soruyu soracak" + txtoyuncu1 + " 'e soracak";
                }
                else if (sayac % 4 == 1)
                {
                    lblmessaj.Text = txtoyuncu3 + "Soruyu soracak" + txtoyuncu2 + " 'e soracak";
                }
                else if (sayac % 4 == 2)
                {
                    lblmessaj.Text = txtoyuncu1 + "Soruyu soracak" + txtoyuncu4 + " 'e soracak";
                }
                else
                {
                    lblmessaj.Text = txtoyuncu2 + "Soruyu soracak" + txtoyuncu3 + " 'e soracak";
                }
           
                timer1.Stop();

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtoyuncu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoyuncu1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtoyuncu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoyuncu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtoyuncu2.Enabled = false;
            }

        }

        private void txtoyuncu3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtoyuncu3.Enabled = false;
                }
            }
        }

        private void txtoyuncu4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtoyuncu4.Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblmessaj_Click(object sender, EventArgs e)
        {

        }
    }
}



    
