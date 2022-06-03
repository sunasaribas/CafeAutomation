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
    public partial class frmMusteriEkleme : Form
    {
        public frmMusteriEkleme()
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
           
            if (txtTelefon.Text.Length>6)
            {
                if (txtMusteriAd.Text==""|| txtMusteriSoyad.Text=="")
                {
                    MessageBox.Show("Lütfen müşterinin ad ve soyad alanlarını doldurunuz");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.MusteriVarmi(txtTelefon.Text);
                    if (!sonuc)
                    {
                        c.Musteriad = txtMusteriAd.Text;
                        c.Musterisoyad = txtMusteriSoyad.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Email = txtEmail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text=c.musteriEkle(c).ToString();
                        if (txtMusteriNo.Text!="")
                        {
                            MessageBox.Show("Müşteri Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenemedi!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde kayıt bulunmaktadır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz.");
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (cGenel._musteriEkleme==0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkleme = 1;
                this.Close();
                frm.Show();

            }
            else if (cGenel._musteriEkleme == 1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._musteriEkleme = 0;
                this.Close();
                frm.Show();
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txtMusteriSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen müşterinin ad ve soyad alanlarını doldurunuz");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    
                    c.Musteriad = txtMusteriAd.Text;
                    c.Musterisoyad = txtMusteriSoyad.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Email = txtEmail.Text;
                    c.Adres = txtAdres.Text;
                    c.Musteriid = Convert.ToInt32(txtMusteriNo.Text);
                    bool sonuc=c.musteriBilgileriGuncelle(c);


                    if (sonuc)
                    {
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri güncellendi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bilgileri güncellenemedi!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde kayıt bulunmaktadır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz.");
            }
        }

        private void frmMusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId>0)
            {
                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.musterigetirID(Convert.ToInt32(txtMusteriNo.Text),txtMusteriAd, txtMusteriSoyad, txtTelefon, txtAdres, txtEmail);

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();
        }
    }
}
