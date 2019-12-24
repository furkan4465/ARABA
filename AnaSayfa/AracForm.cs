using ArabaBLL;
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
    public partial class AracForm : Form
    {
        public AracForm()
        {
            InitializeComponent();
        }

        private void AracForm_Load(object sender, EventArgs e)
        {
            ArabaBL araba = new ArabaBL();

            cmbMarka.DisplayMember = "Kategori_adi";
            cmbMarka.ValueMember = "Kategori_id";
            cmbMarka.DataSource = araba.AracListele(0);
            araba.Dispose();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cmbMarka.SelectedIndex != 0)
            {
                ArabaBL araba = new ArabaBL();
                cmbModel.DisplayMember = "Kategori_adi";
                cmbModel.ValueMember = "Kategori_id";
                cmbModel.DataSource = araba.AracListele((int)cmbMarka.SelectedValue);
                cmbModel.Enabled = true;
                araba.Dispose();

            }
            else
            {
                cmbModel.Enabled = false;
                cmbDonanım.Enabled = false;
            }
        }
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbModel.SelectedIndex!=0 && cmbMarka.SelectedIndex !=0)
            {
                ArabaBL araba = new ArabaBL();
                cmbDonanım.DisplayMember = "Kategori_adi";
                cmbDonanım.ValueMember = "Kategori_id";
                cmbDonanım.DataSource = araba.AracListele((int)cmbModel.SelectedValue);
                cmbDonanım.Enabled = true;
                araba.Dispose();
            }
            else
            {
                cmbDonanım.Enabled = false;
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OzelliklerBL ozbl = new OzelliklerBL();
            dgwaracliste.DataSource = ozbl.Goruntule((int)cmbDonanım.SelectedValue);
            ozbl.Dispose();
        }
    }
}
