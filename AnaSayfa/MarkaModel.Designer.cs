namespace AnaSayfa
{
    partial class MarkaModel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbMarkaGor = new System.Windows.Forms.ComboBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnmodelekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBak = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbMarkaGor);
            this.tabPage1.Controls.Add(this.btnMarkaEkle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMarkaEkle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marka";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmbMarkaGor
            // 
            this.cmbMarkaGor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarkaGor.FormattingEnabled = true;
            this.cmbMarkaGor.Location = new System.Drawing.Point(135, 51);
            this.cmbMarkaGor.Name = "cmbMarkaGor";
            this.cmbMarkaGor.Size = new System.Drawing.Size(121, 21);
            this.cmbMarkaGor.TabIndex = 39;
            this.cmbMarkaGor.SelectedIndexChanged += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Location = new System.Drawing.Point(135, 184);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(121, 23);
            this.btnMarkaEkle.TabIndex = 4;
            this.btnMarkaEkle.Text = "Marka Ekle ";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka Adı";
            // 
            // txtMarkaEkle
            // 
            this.txtMarkaEkle.Location = new System.Drawing.Point(135, 117);
            this.txtMarkaEkle.Name = "txtMarkaEkle";
            this.txtMarkaEkle.Size = new System.Drawing.Size(121, 20);
            this.txtMarkaEkle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olan Markalar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBak);
            this.tabPage2.Controls.Add(this.btnmodelekle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.cmbmodel);
            this.tabPage2.Controls.Add(this.cmbmarka);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnmodelekle
            // 
            this.btnmodelekle.Location = new System.Drawing.Point(171, 242);
            this.btnmodelekle.Name = "btnmodelekle";
            this.btnmodelekle.Size = new System.Drawing.Size(121, 23);
            this.btnmodelekle.TabIndex = 44;
            this.btnmodelekle.Text = "Model Ekleme";
            this.btnmodelekle.UseVisualStyleBackColor = true;
            this.btnmodelekle.Click += new System.EventHandler(this.btnmodelekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Model Ekleme";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 42;
            // 
            // cmbmodel
            // 
            this.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodel.Enabled = false;
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(171, 79);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(121, 21);
            this.cmbmodel.TabIndex = 41;
            this.cmbmodel.SelectedIndexChanged += new System.EventHandler(this.cmbmodel_SelectedIndexChanged);
            // 
            // cmbmarka
            // 
            this.cmbmarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(171, 46);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 40;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Var Olan Marka Ve Model";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Model";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBak
            // 
            this.btnBak.Location = new System.Drawing.Point(81, 79);
            this.btnBak.Name = "btnBak";
            this.btnBak.Size = new System.Drawing.Size(75, 23);
            this.btnBak.TabIndex = 45;
            this.btnBak.Text = "Marka Bakma";
            this.btnBak.UseVisualStyleBackColor = true;
            this.btnBak.Click += new System.EventHandler(this.btnBak_Click);
            // 
            // MarkaModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MarkaModel";
            this.Text = "MarkaModel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarkaGor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmodelekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Button btnBak;
    }
}