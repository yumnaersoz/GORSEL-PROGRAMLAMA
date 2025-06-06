using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;














namespace Görsel_Programlama_1
{










    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {


            string cinsiyet = "";
            if (erkek.Checked)
            {
                cinsiyet = "ERKEK";
            }
            else if (kadın.Checked)
            {
                cinsiyet = "KADIN";
            }
            string hobi = "";
            foreach(object a in liste.CheckedItems)
            {
                hobi += a.ToString() + " ";
            }
            DataGridViewRow eklenen = (DataGridViewRow)kisiliste.Rows[0].Clone();
            eklenen.Cells[0].Value = txtad.Text+""+txtsoyad.Text;
            eklenen.Cells[1].Value = cinsiyet;
            eklenen.Cells[2].Value = txtmeslek.Text;
            eklenen.Cells[3].Value = hobi;
            kisiliste.Rows.Add(eklenen);

        }






        private void btnhobi_Click(object sender, EventArgs e)
        {
            liste.Items.Add(txthobi.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kisiliste.SelectedRows.Count > 0)
            {
                kisiliste.Rows.RemoveAt(kisiliste.SelectedRows[0].Index);
            }
        }

        private void kisiliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
