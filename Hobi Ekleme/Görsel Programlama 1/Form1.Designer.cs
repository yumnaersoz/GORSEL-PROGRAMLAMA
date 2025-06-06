namespace Görsel_Programlama_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.GroupBox();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.liste = new System.Windows.Forms.CheckedListBox();
            this.btnhobi = new System.Windows.Forms.Button();
            this.txthobi = new System.Windows.Forms.TextBox();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kisiliste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisiliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(88, 0);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(88, 41);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "MESLEK:";
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(88, 100);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(100, 22);
            this.txtmeslek.TabIndex = 6;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Controls.Add(this.kadın);
            this.cinsiyet.Controls.Add(this.erkek);
            this.cinsiyet.Location = new System.Drawing.Point(3, 170);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(236, 100);
            this.cinsiyet.TabIndex = 8;
            this.cinsiyet.TabStop = false;
            this.cinsiyet.Text = "CİNSİYET:";
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Location = new System.Drawing.Point(125, 34);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(68, 20);
            this.kadın.TabIndex = 1;
            this.kadın.TabStop = true;
            this.kadın.Text = "KADIN";
            this.kadın.UseVisualStyleBackColor = true;
            this.kadın.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(10, 34);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(72, 20);
            this.erkek.TabIndex = 0;
            this.erkek.TabStop = true;
            this.erkek.Text = "ERKEK";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Items.AddRange(new object[] {
            "FUTBOL",
            "BASKETBOL",
            "BALE",
            "MÜZİK",
            "DANS",
            "DAĞCILIK",
            "SİNEMA",
            "KAYAK",
            ""});
            this.liste.Location = new System.Drawing.Point(813, 12);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(216, 123);
            this.liste.TabIndex = 9;
            this.liste.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnhobi
            // 
            this.btnhobi.Location = new System.Drawing.Point(1192, 23);
            this.btnhobi.Name = "btnhobi";
            this.btnhobi.Size = new System.Drawing.Size(94, 23);
            this.btnhobi.TabIndex = 10;
            this.btnhobi.Text = "HOBİ EKLE";
            this.btnhobi.UseVisualStyleBackColor = true;
            this.btnhobi.Click += new System.EventHandler(this.btnhobi_Click);
            // 
            // txthobi
            // 
            this.txthobi.Location = new System.Drawing.Point(1069, 24);
            this.txthobi.Name = "txthobi";
            this.txthobi.Size = new System.Drawing.Size(100, 22);
            this.txthobi.TabIndex = 11;
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(796, 159);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 12;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Seçili Kaydı Sİl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kisiliste
            // 
            this.kisiliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kisiliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.kisiliste.Location = new System.Drawing.Point(377, 257);
            this.kisiliste.Name = "kisiliste";
            this.kisiliste.RowHeadersWidth = 51;
            this.kisiliste.RowTemplate.Height = 24;
            this.kisiliste.Size = new System.Drawing.Size(548, 181);
            this.kisiliste.TabIndex = 14;
            this.kisiliste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kisiliste_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AD SOYAD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CİNSİYET";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MESLEK";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "HOBİLER";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kisiliste);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.txthobi);
            this.Controls.Add(this.btnhobi);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.txtmeslek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cinsiyet.ResumeLayout(false);
            this.cinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisiliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.GroupBox cinsiyet;
        private System.Windows.Forms.RadioButton kadın;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.CheckedListBox liste;
        private System.Windows.Forms.Button btnhobi;
        private System.Windows.Forms.TextBox txthobi;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView kisiliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

