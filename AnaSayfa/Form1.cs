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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrnGiris_Click(object sender, EventArgs e)
        {
            String Kullanıcı;
            string sifre;

            Kullanıcı = txtKullanıcı.Text;
            sifre = txtSifre.Text;
            if (Kullanıcı == "furkan" && sifre == "123456")
            {
                this.Hide();
                KayıtForm frm = new KayıtForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btnGör_Click(object sender, EventArgs e)
        {
            AracForm frm1 = new AracForm();
            frm1.Show();
        }
    }
}
