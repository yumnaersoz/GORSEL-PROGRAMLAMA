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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();  // Uygulamayı kapat
        }

        private void btnYeniKargo_Click(object sender, EventArgs e)
        {
            CreateShipmentForm form = new CreateShipmentForm(this);
            form.Show();
            this.Hide();  // MainForm'u gizle
        }

        private void btnKargoListesi_Click(object sender, EventArgs e)
        {
            ShipmentListForm listeForm = new ShipmentListForm(this);
            listeForm.Show();
            this.Hide();  // MainForm'u gizle
        }

    }
}
