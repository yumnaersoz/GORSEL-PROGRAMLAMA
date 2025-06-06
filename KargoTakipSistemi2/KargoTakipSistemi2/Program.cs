using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipSistemi2
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();  // Uygulama stilini etkinleştir
            Application.SetCompatibleTextRenderingDefault(false);  // Yazı tipi uyumluluğunu sağla

            // Uygulama başlatıldığında LoginForm'u aç
            Application.Run(new LoginForm());

        }
    }
}