using ArabaBLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaSayfa
{
    public partial class MarkaModel : Form
    {
        public int Ust_Kategori_id = 0;

        Helper hlp = new Helper();
        public MarkaModel()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();

            cmbMarkaGor.DisplayMember = "Kategori_adi";
            cmbMarkaGor.ValueMember = "Kategori_id";
            cmbMarkaGor.DataSource = araba.AracListele(0);
            araba.Dispose();
        }

        private void cmbMarkaGor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();
            cmbMarkaGor.DisplayMember = "Kategori_adi";
            cmbMarkaGor.ValueMember = "Kategori_id";
            cmbMarkaGor.DataSource = araba.AracListele((int)cmbMarkaGor.SelectedValue); // object dönüyor ondan intine ihtiyaç dönüyor methodun id ye ihtiyacı var
            
            araba.Dispose();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            ArabaBL abl = new ArabaBL();
            try
            {
                Araba araba = new Araba();
                araba.Kategori_adi = txtMarkaEkle.Text.Trim();
                araba.Ust_Kategori_id = Ust_Kategori_id;

                if (Ust_Kategori_id == 0)
                {
                    MessageBox.Show(abl.ArabaEkle(araba) ? "Başarılı" : "Başarısız");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmarka.SelectedIndex != 0) 
            {
                ArabaBL araba = new ArabaBL();
                cmbmodel.DisplayMember = "Kategori_adi";
                cmbmodel.ValueMember = "Kategori_id";
                cmbmodel.DataSource = araba.AracListele((int)cmbmarka.SelectedValue); 
                cmbmodel.Enabled = true;
                araba.Dispose();
            }
            else
            {
                cmbmodel.Enabled = false; 
            }
        }

        private void cmbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();

            cmbmodel.DisplayMember = "Kategori_adi";
            cmbmodel.ValueMember = "Kategori_id";
            cmbmodel.DataSource = araba.AracListele(0);
            araba.Dispose();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmodelekle_Click(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();
            Araba araba1 = new Araba();
            araba1.Kategori_adi = txtMarkaEkle.Text.Trim();
            araba1.Ust_Kategori_id = (int)cmbmarka.SelectedValue;
            
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();

            cmbmarka.DisplayMember = "Kategori_adi";
            cmbmarka.ValueMember = "Kategori_id";
            cmbmarka.DataSource = araba.AracListele(0);
            araba.Dispose();
        }
    }
}
