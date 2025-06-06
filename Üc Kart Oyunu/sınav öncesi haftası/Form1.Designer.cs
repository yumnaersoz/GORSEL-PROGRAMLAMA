namespace sınav_öncesi_haftası
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNYENİOYUN = new System.Windows.Forms.Button();
            this.BTNOYUNUBASLAT = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblzaman = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(353, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(539, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // BTNYENİOYUN
            // 
            this.BTNYENİOYUN.Location = new System.Drawing.Point(370, 321);
            this.BTNYENİOYUN.Name = "BTNYENİOYUN";
            this.BTNYENİOYUN.Size = new System.Drawing.Size(107, 46);
            this.BTNYENİOYUN.TabIndex = 3;
            this.BTNYENİOYUN.Text = "YENİ OYUN";
            this.BTNYENİOYUN.UseVisualStyleBackColor = true;
            this.BTNYENİOYUN.Visible = false;
            this.BTNYENİOYUN.Click += new System.EventHandler(this.BTNYENİOYUN_Click);
            // 
            // BTNOYUNUBASLAT
            // 
            this.BTNOYUNUBASLAT.Location = new System.Drawing.Point(370, 387);
            this.BTNOYUNUBASLAT.Name = "BTNOYUNUBASLAT";
            this.BTNOYUNUBASLAT.Size = new System.Drawing.Size(107, 51);
            this.BTNOYUNUBASLAT.TabIndex = 4;
            this.BTNOYUNUBASLAT.Text = "OYUNU BAŞLAT";
            this.BTNOYUNUBASLAT.UseVisualStyleBackColor = true;
            this.BTNOYUNUBASLAT.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(752, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "KALAN SÜRE:";
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.Location = new System.Drawing.Point(863, 69);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(23, 16);
            this.lblzaman.TabIndex = 6;
            this.lblzaman.Text = "10";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(752, 387);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(118, 16);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "TOPLAM PUAN:";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(870, 387);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(15, 16);
            this.lblpuan.TabIndex = 8;
            this.lblpuan.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BTNOYUNUBASLAT);
            this.Controls.Add(this.BTNYENİOYUN);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNYENİOYUN;
        private System.Windows.Forms.Button BTNOYUNUBASLAT;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

