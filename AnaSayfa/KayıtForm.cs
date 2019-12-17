using ArabaBLL;
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
using DAL;
using Model;

namespace AnaSayfa
{
    public partial class KayıtForm : Form
    {
        Helper hlp = new Helper();

        public int kategori_id = 0;
        
        public KayıtForm()
        {
            InitializeComponent();
        }

        
      
        private void button1_Click_1(object sender, EventArgs e)
        {

            OzelliklerBL ozbl = new OzelliklerBL();
            dgw1.DataSource = ozbl.AracBilgileri();
            ozbl.Dispose();
            // OzelliklerBL vericek = new OzelliklerBL();
            // dgw1.DataSource = vericek.Goruntule1();
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            

        }
        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OzelliklerBL ozl = new OzelliklerBL();
            try
            {
                
                Ozellikler ozellikler = new Ozellikler();
                ozellikler.Tipi = txtTipi.Text.Trim();
                ozellikler.Cekis = txtcekis.Text.Trim();
                ozellikler.Motor = Convert.ToInt32(txtmotor.Text.Trim());
                ozellikler.Beygir = Convert.ToInt32(txtbeygir.Text.Trim());
                ozellikler.Tork = Convert.ToInt32(txttork.Text.Trim());
                ozellikler.YTüketimi = Convert.ToInt32(txttork.Text.Trim());
                ozellikler.YTürü = txtyturu.Text.Trim();
                ozellikler.SonHiz = Convert.ToInt32(txtsonhız.Text.Trim());
                ozellikler.Hizlanma = Convert.ToInt32(txthızlanma.Text.Trim());
                ozellikler.Yili = Convert.ToInt32(txtyılı.Text.Trim());
                ozellikler.Kategori_id =(int) cmbdonanım.SelectedValue;

                if (kategori_id==0)
                {
                    MessageBox.Show(ozl.OzellikKaydet(ozellikler) ? "Başarılı" : "Başarısız");
                }
            }
            catch (Exception  )
            {
                throw;
               // MessageBox.Show("Veritabanı hatası!" + ex);
            }            
            finally
            {
                ozl.Dispose();
            }



        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();

            cmbmarka.DisplayMember = "Kategori_adi";
            cmbmarka.ValueMember = "Kategori_id";
            cmbmarka.DataSource = araba.AracListele(0);
            araba.Dispose();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmodel.SelectedIndex != 0 && cmbmarka.SelectedIndex != 0)
            {
                ArabaBL araba = new ArabaBL();
                cmbdonanım.DisplayMember = "Kategori_adi";
                cmbdonanım.ValueMember = "Kategori_id";
                cmbdonanım.DataSource = araba.AracListele((int)cmbmodel.SelectedValue);
                cmbdonanım.Enabled = true;
                araba.Dispose();
            }
            else
            {
                cmbmodel.Enabled = false;
                cmbdonanım.Enabled = false;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmarka.SelectedIndex != 0 )
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

        
    }
}
