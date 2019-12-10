namespace AnaSayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BrnGiris = new System.Windows.Forms.Button();
            this.btnGör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Sifre";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(90, 132);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcı.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(90, 158);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // BrnGiris
            // 
            this.BrnGiris.Location = new System.Drawing.Point(90, 184);
            this.BrnGiris.Name = "BrnGiris";
            this.BrnGiris.Size = new System.Drawing.Size(100, 44);
            this.BrnGiris.TabIndex = 4;
            this.BrnGiris.Text = "Kayıt İşlemi İçinGiriş";
            this.BrnGiris.UseVisualStyleBackColor = true;
            this.BrnGiris.Click += new System.EventHandler(this.BrnGiris_Click);
            // 
            // btnGör
            // 
            this.btnGör.Location = new System.Drawing.Point(6, 58);
            this.btnGör.Name = "btnGör";
            this.btnGör.Size = new System.Drawing.Size(184, 42);
            this.btnGör.TabIndex = 5;
            this.btnGör.Text = "Araba Görüntüleme";
            this.btnGör.UseVisualStyleBackColor = true;
            this.btnGör.Click += new System.EventHandler(this.btnGör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 310);
            this.Controls.Add(this.btnGör);
            this.Controls.Add(this.BrnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BrnGiris;
        private System.Windows.Forms.Button btnGör;
    }
}

