namespace KargoTakipSistemi2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnYeniKargo = new System.Windows.Forms.Button();
            this.btnKargoListesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "ÇIKIŞ YAPINIZ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnYeniKargo
            // 
            this.btnYeniKargo.Location = new System.Drawing.Point(329, 145);
            this.btnYeniKargo.Name = "btnYeniKargo";
            this.btnYeniKargo.Size = new System.Drawing.Size(75, 44);
            this.btnYeniKargo.TabIndex = 2;
            this.btnYeniKargo.Text = "YENİ KARGO";
            this.btnYeniKargo.UseVisualStyleBackColor = true;
            this.btnYeniKargo.Click += new System.EventHandler(this.btnYeniKargo_Click);
            // 
            // btnKargoListesi
            // 
            this.btnKargoListesi.Location = new System.Drawing.Point(332, 206);
            this.btnKargoListesi.Name = "btnKargoListesi";
            this.btnKargoListesi.Size = new System.Drawing.Size(75, 47);
            this.btnKargoListesi.TabIndex = 3;
            this.btnKargoListesi.Text = "KARGO LİSTESİ";
            this.btnKargoListesi.UseVisualStyleBackColor = true;
            this.btnKargoListesi.Click += new System.EventHandler(this.btnKargoListesi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKargoListesi);
            this.Controls.Add(this.btnYeniKargo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnYeniKargo;
        private System.Windows.Forms.Button btnKargoListesi;
    }
}