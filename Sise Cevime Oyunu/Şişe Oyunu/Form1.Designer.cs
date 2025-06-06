namespace Şişe_Oyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtoyuncu1 = new System.Windows.Forms.TextBox();
            this.txtoyuncu2 = new System.Windows.Forms.TextBox();
            this.txtoyuncu3 = new System.Windows.Forms.TextBox();
            this.txtoyuncu4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblmessaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtoyuncu1
            // 
            this.txtoyuncu1.Location = new System.Drawing.Point(87, 12);
            this.txtoyuncu1.Name = "txtoyuncu1";
            this.txtoyuncu1.Size = new System.Drawing.Size(100, 22);
            this.txtoyuncu1.TabIndex = 1;
            this.txtoyuncu1.TextChanged += new System.EventHandler(this.txtoyuncu1_TextChanged);
            this.txtoyuncu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoyuncu1_KeyPress);
            // 
            // txtoyuncu2
            // 
            this.txtoyuncu2.Location = new System.Drawing.Point(654, 12);
            this.txtoyuncu2.Name = "txtoyuncu2";
            this.txtoyuncu2.Size = new System.Drawing.Size(100, 22);
            this.txtoyuncu2.TabIndex = 2;
            this.txtoyuncu2.TextChanged += new System.EventHandler(this.txtoyuncu2_TextChanged);
            this.txtoyuncu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoyuncu2_KeyPress);
            // 
            // txtoyuncu3
            // 
            this.txtoyuncu3.Location = new System.Drawing.Point(87, 342);
            this.txtoyuncu3.Name = "txtoyuncu3";
            this.txtoyuncu3.Size = new System.Drawing.Size(100, 22);
            this.txtoyuncu3.TabIndex = 3;
            this.txtoyuncu3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoyuncu3_KeyPress);
            // 
            // txtoyuncu4
            // 
            this.txtoyuncu4.Location = new System.Drawing.Point(633, 332);
            this.txtoyuncu4.Name = "txtoyuncu4";
            this.txtoyuncu4.Size = new System.Drawing.Size(100, 22);
            this.txtoyuncu4.TabIndex = 4;
            this.txtoyuncu4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoyuncu4_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "OYUNU BAŞLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmessaj
            // 
            this.lblmessaj.AutoSize = true;
            this.lblmessaj.Location = new System.Drawing.Point(359, 425);
            this.lblmessaj.Name = "lblmessaj";
            this.lblmessaj.Size = new System.Drawing.Size(0, 16);
            this.lblmessaj.TabIndex = 6;
            this.lblmessaj.Click += new System.EventHandler(this.lblmessaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmessaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtoyuncu4);
            this.Controls.Add(this.txtoyuncu3);
            this.Controls.Add(this.txtoyuncu2);
            this.Controls.Add(this.txtoyuncu1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtoyuncu1;
        private System.Windows.Forms.TextBox txtoyuncu2;
        private System.Windows.Forms.TextBox txtoyuncu3;
        private System.Windows.Forms.TextBox txtoyuncu4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblmessaj;
    }
}

