namespace AnaSayfa
{
    partial class KayıtForm
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
            this.lbltipi = new System.Windows.Forms.Label();
            this.lblcekis = new System.Windows.Forms.Label();
            this.lblmotor = new System.Windows.Forms.Label();
            this.lblbeygir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTipi = new System.Windows.Forms.TextBox();
            this.txtcekis = new System.Windows.Forms.TextBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.txtbeygir = new System.Windows.Forms.TextBox();
            this.txttork = new System.Windows.Forms.TextBox();
            this.txtytuketimi = new System.Windows.Forms.TextBox();
            this.txtyturu = new System.Windows.Forms.TextBox();
            this.txtsonhız = new System.Windows.Forms.TextBox();
            this.txthızlanma = new System.Windows.Forms.TextBox();
            this.txtyılı = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clmTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCekis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBeygir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYtüketimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYtürü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSonHız = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltipi
            // 
            this.lbltipi.AutoSize = true;
            this.lbltipi.Location = new System.Drawing.Point(5, 266);
            this.lbltipi.Name = "lbltipi";
            this.lbltipi.Size = new System.Drawing.Size(24, 13);
            this.lbltipi.TabIndex = 5;
            this.lbltipi.Text = "Tipi";
            // 
            // lblcekis
            // 
            this.lblcekis.AutoSize = true;
            this.lblcekis.Location = new System.Drawing.Point(5, 292);
            this.lblcekis.Name = "lblcekis";
            this.lblcekis.Size = new System.Drawing.Size(33, 13);
            this.lblcekis.TabIndex = 6;
            this.lblcekis.Text = "Çekiş";
            // 
            // lblmotor
            // 
            this.lblmotor.AutoSize = true;
            this.lblmotor.Location = new System.Drawing.Point(5, 318);
            this.lblmotor.Name = "lblmotor";
            this.lblmotor.Size = new System.Drawing.Size(34, 13);
            this.lblmotor.TabIndex = 7;
            this.lblmotor.Text = "Motor";
            // 
            // lblbeygir
            // 
            this.lblbeygir.AutoSize = true;
            this.lblbeygir.Location = new System.Drawing.Point(5, 346);
            this.lblbeygir.Name = "lblbeygir";
            this.lblbeygir.Size = new System.Drawing.Size(36, 13);
            this.lblbeygir.TabIndex = 8;
            this.lblbeygir.Text = "Beygir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tork";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Yakıt Tüketimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Yakıt Türü";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Son hız";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Hızlanma";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Yılı";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(165, 415);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 18;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dgw1
            // 
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTipi,
            this.clmCekis,
            this.clmMotor,
            this.clmBeygir,
            this.clmTork,
            this.clmYtüketimi,
            this.clmYtürü,
            this.clmSonHız,
            this.clmYili});
            this.dgw1.Location = new System.Drawing.Point(77, 12);
            this.dgw1.Name = "dgw1";
            this.dgw1.Size = new System.Drawing.Size(711, 150);
            this.dgw1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(342, 182);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(86, 259);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(100, 20);
            this.txtTipi.TabIndex = 22;
            // 
            // txtcekis
            // 
            this.txtcekis.Location = new System.Drawing.Point(86, 285);
            this.txtcekis.Name = "txtcekis";
            this.txtcekis.Size = new System.Drawing.Size(100, 20);
            this.txtcekis.TabIndex = 23;
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(86, 311);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(100, 20);
            this.txtmotor.TabIndex = 24;
            // 
            // txtbeygir
            // 
            this.txtbeygir.Location = new System.Drawing.Point(86, 339);
            this.txtbeygir.Name = "txtbeygir";
            this.txtbeygir.Size = new System.Drawing.Size(100, 20);
            this.txtbeygir.TabIndex = 25;
            // 
            // txttork
            // 
            this.txttork.Location = new System.Drawing.Point(86, 365);
            this.txttork.Name = "txttork";
            this.txttork.Size = new System.Drawing.Size(100, 20);
            this.txttork.TabIndex = 26;
            // 
            // txtytuketimi
            // 
            this.txtytuketimi.Location = new System.Drawing.Point(300, 263);
            this.txtytuketimi.Name = "txtytuketimi";
            this.txtytuketimi.Size = new System.Drawing.Size(100, 20);
            this.txtytuketimi.TabIndex = 27;
            // 
            // txtyturu
            // 
            this.txtyturu.Location = new System.Drawing.Point(300, 289);
            this.txtyturu.Name = "txtyturu";
            this.txtyturu.Size = new System.Drawing.Size(100, 20);
            this.txtyturu.TabIndex = 28;
            // 
            // txtsonhız
            // 
            this.txtsonhız.Location = new System.Drawing.Point(300, 318);
            this.txtsonhız.Name = "txtsonhız";
            this.txtsonhız.Size = new System.Drawing.Size(100, 20);
            this.txtsonhız.TabIndex = 29;
            // 
            // txthızlanma
            // 
            this.txthızlanma.Location = new System.Drawing.Point(300, 344);
            this.txthızlanma.Name = "txthızlanma";
            this.txthızlanma.Size = new System.Drawing.Size(100, 20);
            this.txthızlanma.TabIndex = 30;
            // 
            // txtyılı
            // 
            this.txtyılı.Location = new System.Drawing.Point(300, 370);
            this.txtyılı.Name = "txtyılı";
            this.txtyılı.Size = new System.Drawing.Size(100, 20);
            this.txtyılı.TabIndex = 31;
            // 
            // clmTipi
            // 
            this.clmTipi.HeaderText = "Araç Tipi";
            this.clmTipi.Name = "clmTipi";
            // 
            // clmCekis
            // 
            this.clmCekis.HeaderText = "Çekiş Türü";
            this.clmCekis.Name = "clmCekis";
            // 
            // clmMotor
            // 
            this.clmMotor.HeaderText = "Motor";
            this.clmMotor.Name = "clmMotor";
            // 
            // clmBeygir
            // 
            this.clmBeygir.HeaderText = "Beygir";
            this.clmBeygir.Name = "clmBeygir";
            // 
            // clmTork
            // 
            this.clmTork.HeaderText = "Tork";
            this.clmTork.Name = "clmTork";
            // 
            // clmYtüketimi
            // 
            this.clmYtüketimi.HeaderText = "Yakıt Tüketimi";
            this.clmYtüketimi.Name = "clmYtüketimi";
            // 
            // clmYtürü
            // 
            this.clmYtürü.HeaderText = "Yakıt Türü";
            this.clmYtürü.Name = "clmYtürü";
            // 
            // clmSonHız
            // 
            this.clmSonHız.HeaderText = "Son Hızı";
            this.clmSonHız.Name = "clmSonHız";
            // 
            // clmYili
            // 
            this.clmYili.HeaderText = "Araç Yılı";
            this.clmYili.Name = "clmYili";
            // 
            // KayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtyılı);
            this.Controls.Add(this.txthızlanma);
            this.Controls.Add(this.txtsonhız);
            this.Controls.Add(this.txtyturu);
            this.Controls.Add(this.txtytuketimi);
            this.Controls.Add(this.txttork);
            this.Controls.Add(this.txtbeygir);
            this.Controls.Add(this.txtmotor);
            this.Controls.Add(this.txtcekis);
            this.Controls.Add(this.txtTipi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblbeygir);
            this.Controls.Add(this.lblmotor);
            this.Controls.Add(this.lblcekis);
            this.Controls.Add(this.lbltipi);
            this.Name = "KayıtForm";
            this.Text = "KayıtForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltipi;
        private System.Windows.Forms.Label lblcekis;
        private System.Windows.Forms.Label lblmotor;
        private System.Windows.Forms.Label lblbeygir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTipi;
        private System.Windows.Forms.TextBox txtcekis;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.TextBox txtbeygir;
        private System.Windows.Forms.TextBox txttork;
        private System.Windows.Forms.TextBox txtytuketimi;
        private System.Windows.Forms.TextBox txtyturu;
        private System.Windows.Forms.TextBox txtsonhız;
        private System.Windows.Forms.TextBox txthızlanma;
        private System.Windows.Forms.TextBox txtyılı;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCekis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBeygir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTork;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYtüketimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYtürü;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSonHız;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYili;
    }
}