using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace KargoTakipSistemi2
{
    public partial class ShipmentListForm : Form
    {
        private Form previousForm;

        public ShipmentListForm(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;
        }

        private void ShipmentListForm_Load(object sender, EventArgs e)
       
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\yumna\\Downloads\\ChatGPT Image 26 May 2025 15_59_29.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            cmbDurum.Items.Add("Yola Çıktı");
            cmbDurum.Items.Add("Dağıtımda");
            cmbDurum.Items.Add("Teslim Edildi");
            cmbDurum.Items.Add("İade Edildi");

            DataGridviewStilAyarla(); // Stil uygulama
            KargolariListele();       // Veri çekme
        }

        
      

        private void KargolariListele()
        {
            string conString = ConfigurationManager.ConnectionStrings["KargoDBBaglantisi"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string sorgu = "SELECT * FROM Kargolar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Buraya satır kontrolü ekle
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"{dt.Rows.Count} adet kargo listelendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hiç kargo bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananTakipNo = txtTakipNo.Text.Trim();

            if (string.IsNullOrEmpty(arananTakipNo))
            {
                MessageBox.Show("Lütfen aramak için bir takip numarası girin.");
                return;
            }

            string conString = ConfigurationManager.ConnectionStrings["KargoDBBaglantisi"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                string sorgu = "SELECT * FROM Kargolar WHERE TakipNo LIKE @tn";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                da.SelectCommand.Parameters.AddWithValue("@tn", "%" + arananTakipNo + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnDurumuGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir kargo seçin.");
                return;
            }

            string yeniDurum = cmbDurum.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(yeniDurum))
            {
                MessageBox.Show("Lütfen bir durum seçin.");
                return;
            }

            string takipNo = dataGridView1.SelectedRows[0].Cells["TakipNo"].Value.ToString();
            string conString = ConfigurationManager.ConnectionStrings["KargoDBBaglantisi"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string sorgu = "UPDATE Kargolar SET Durum = @d WHERE TakipNo = @tn";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@d", yeniDurum);
                cmd.Parameters.AddWithValue("@tn", takipNo);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kargo durumu başarıyla güncellendi.");
                KargolariListele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string takipNo = dataGridView1.Rows[e.RowIndex].Cells["TakipNo"].Value.ToString();
                txtTakipNo.Text = takipNo; // otomatik doldurma gibi bir işlev istersen
            }
        }
        private void DataGridviewStilAyarla()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.LightGray;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void txtTakipNo_TextChanged(object sender, EventArgs e)
        {
            // Gerekirse otomatik filtreleme buraya yazılabilir
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Durum değişikliğinde özel işlem yapılacaksa buraya eklenebilir
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Örneğin:
            MessageBox.Show("Button1 tıklandı.");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KargolariListele();
        }
    }
}
