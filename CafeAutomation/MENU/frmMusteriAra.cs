using CafeOtomasyonu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu.MENU
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme m = new frmMusteriEkleme();
            cGenel._musteriEkleme = 1;
            m.btnMusteriGuncelle.Visible = false;
            m.label7.Visible = false;
            m.label8.Visible = false;
            m.btnMusteriSec.Visible = false;
            m.btnYeniMusteri.Visible = true;


            this.Close();
            m.Show();
            
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musterileriGetir(lvMusteriler);
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {



        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {

                frmMusteriEkleme frm = new frmMusteriEkleme();

                cGenel._musteriEkleme = 1;
                cGenel._musteriId =Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                frm.btnYeniMusteri.Visible = false;
                frm.btnMusteriSec.Visible = false;
                frm.btnMusteriGuncelle.Visible = true;
                frm.label6.Visible = false;
                frm.label7.Visible = false; 
                this.Close();
                frm.Show();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musterigetirAd(lvMusteriler, txtMusteriAd.Text);
        }

        private void btnAdisyonBul_Click(object sender, EventArgs e)
        {
            if (txtAdisyonid.Text!="")
            {
                cGenel._AdisyonId = txtAdisyonid.Text;
                cPaketler c = new cPaketler();
                bool sonuc = c.getCheckOpenAdditionID(Convert.ToInt32(txtAdisyonid.Text));
                if (sonuc)
                {
                    frmBill frm = new frmBill();
                    cGenel._ServisTurNo = 2;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show(txtAdisyonid.Text +" Nolu adisyon bunuamadı.");
                }

            }
            else
            {
                MessageBox.Show("Aramak istediğiniz Adisyonu Yazınız.");
            }
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            frm.Show();
        }
    }
}
