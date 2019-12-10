﻿using ArabaBLL;
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
            OzelliklerBL ozbl = new OzelliklerBL();
            if (ozbl.Guncelle(dgw1))
            {
                MessageBox.Show("işlem yapıldı..");
            }
            else
            {
                MessageBox.Show("HATA SALAH");
            }

        }
        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KayıtForm frm = (KayıtForm)Application.OpenForms["KayıtForm"];

            frm.txtTipi.Text = dgw1.Rows[e.RowIndex].Cells["clmTipi"].Value.ToString();
            frm.txtcekis.Text = dgw1.Rows[e.RowIndex].Cells["clmcekis"].Value.ToString();
            frm.txtmotor.Text = dgw1.Rows[e.RowIndex].Cells["clmMotor"].Value.ToString();
            frm.txtbeygir.Text = dgw1.Rows[e.RowIndex].Cells["clmBeygir"].Value.ToString();
            frm.txttork.Text = dgw1.Rows[e.RowIndex].Cells["clmTork"].Value.ToString();
            frm.txtytuketimi.Text = dgw1.Rows[e.RowIndex].Cells["clmYtüketimi"].Value.ToString();
            frm.txtyturu.Text = dgw1.Rows[e.RowIndex].Cells["clmYtürü"].Value.ToString();
            frm.txtsonhız.Text = dgw1.Rows[e.RowIndex].Cells["clmSonhiz"].Value.ToString();
            frm.txthızlanma.Text = dgw1.Rows[e.RowIndex].Cells["clmHizlanma"].Value.ToString();
            frm.txtyılı.Text = dgw1.Rows[e.RowIndex].Cells["clmYili"].Value.ToString();


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
                ozellikler.Kategori_id = kategori_id;

                if (kategori_id==0)
                {
                    MessageBox.Show(ozl.OzellikKaydet(ozellikler) ? "Başarılı" : "Başarısız");
                }
            }
            catch (Exception ex )
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
            OzelliklerBL ozbl = new OzelliklerBL();
            dgw1.DataSource = ozbl.ArabaTablosu();
        }
    }
}
