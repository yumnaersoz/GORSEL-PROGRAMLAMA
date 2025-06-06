using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipSistemi2
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi kontrol et
            string correctUsername = "admin";  // Örnek doğru kullanıcı adı
            string correctPassword = "1234";   // Örnek doğru şifre

            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            // Kullanıcı adı ve şifreyi karşılaştır
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                // Başarılı giriş, ana ekrana geçiş yap
                MessageBox.Show("Giriş başarılı!");
                MainForm mainForm = new MainForm();  // Ana formu aç
                mainForm.Show();
                this.Hide();  // Giriş formunu gizle
            }
            else
            {
                // Hatalı giriş, uyarı ver
                MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.");
            }
        }
    }
    }

