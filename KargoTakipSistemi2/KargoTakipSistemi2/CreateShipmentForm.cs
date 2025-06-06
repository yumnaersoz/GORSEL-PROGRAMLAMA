using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipSistemi2
{
    public partial class CreateShipmentForm : Form
    {
        private Form previousForm;

        public CreateShipmentForm(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;

            // Responsive ayarlar (Anchor)
            txtGonderen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlici.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpTarih.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGeri.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // İsteğe bağlı alan
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-SUDFQGP\\SQLEXPRESS;Initial Catalog=KargoDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string takipNo = Guid.NewGuid().ToString().Substring(0, 8);
                string sorgu = "INSERT INTO Kargolar (Gonderen, Alici, Adres, Tarih, TakipNo, Durum) VALUES (@g, @a, @adres, @t, @tn, @d)";

                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@g", txtGonderen.Text);
                cmd.Parameters.AddWithValue("@a", txtAlici.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@t", dtpTarih.Value);
                cmd.Parameters.AddWithValue("@tn", takipNo);
                cmd.Parameters.AddWithValue("@d", "Yola Çıktı");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"Kargo başarıyla eklendi.\nTakip No: {takipNo}");
            }
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
