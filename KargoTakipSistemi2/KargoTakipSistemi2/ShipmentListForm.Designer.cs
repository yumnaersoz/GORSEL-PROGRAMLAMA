﻿namespace KargoTakipSistemi2
{
    partial class ShipmentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnDurumuGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnYenile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnYenile.Location = new System.Drawing.Point(202, 390);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTakipNo.Location = new System.Drawing.Point(235, 58);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(100, 22);
            this.txtTakipNo.TabIndex = 2;
            this.txtTakipNo.TextChanged += new System.EventHandler(this.txtTakipNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TAKİP NO :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAra.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAra.Location = new System.Drawing.Point(428, 58);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(129, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARAMA YAPINIZ";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(235, 99);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 24);
            this.cmbDurum.TabIndex = 5;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
            // 
            // btnDurumuGuncelle
            // 
            this.btnDurumuGuncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDurumuGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDurumuGuncelle.Location = new System.Drawing.Point(428, 99);
            this.btnDurumuGuncelle.Name = "btnDurumuGuncelle";
            this.btnDurumuGuncelle.Size = new System.Drawing.Size(129, 23);
            this.btnDurumuGuncelle.TabIndex = 6;
            this.btnDurumuGuncelle.Text = "GÜNCELLE";
            this.btnDurumuGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumuGuncelle.Click += new System.EventHandler(this.btnDurumuGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DURUM : ";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(503, 390);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "GERİ ÇIK";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ShipmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDurumuGuncelle);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTakipNo);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShipmentListForm";
            this.Text = "ShipmentListForm";
            this.Load += new System.EventHandler(this.ShipmentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnDurumuGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
    }
}