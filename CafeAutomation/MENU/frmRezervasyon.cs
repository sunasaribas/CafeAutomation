using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CafeOtomasyonu.Classes;
using CafeOtomasyonu.MENU;

namespace CafeOtomasyonu
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musterileriGetir(lvMusteriler);

            cMasalar masa = new cMasalar();
            masa.MasaKapasitesiveDurumuGetir(cbMasa);
            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;

        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musterigetirAd(lvMusteriler, txtMusteriAd.Text);


        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musterigetirTlf(lvMusteriler, txtTelefon.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musterigetirAd(lvMusteriler, txtAdres.Text);
        }

        void Temizle()
        {
            txtAdres.Clear();
            txtKisiSayisi.Clear();
            txtMasa.Clear();
            txtTarih.Clear();
            txtTelefon.Clear();
        }

        private void btnRezervasyonAc_Click(object sender, EventArgs e)
        {
            cRezervasyon r = new cRezervasyon();
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                bool sonuc = r.RezervasyonAcikmiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                if (!sonuc)
                {
                    if (txtTarih.Text != "")
                    {
                        if (txtKisiSayisi.Text != "")
                        {
                            cMasalar masa = new cMasalar();

                            if (masa.TableGetbyState(Convert.ToInt32(txtMasaNo.Text), 1))
                            {
                                cAdisyon a = new cAdisyon();// once adısyon sonra rezervasyon acılıyor
                                a.Tarih = Convert.ToDateTime(txtTarih.Text);
                                a.ServisTurNo = 1;
                                a.MasaId = Convert.ToInt32(txtMasaNo.Text);
                                a.PersonelId = cGenel._personelId;

                                r.ClientId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                                r.TableId = Convert.ToInt32(txtMasaNo.Text); ;
                                r.Date = Convert.ToDateTime(txtTarih.Text);
                                r.ClientCount = Convert.ToInt32(txtKisiSayisi.Text);
                                r.Description = txtAciklama.Text;

                                r.AdditionId = a.RezervasyonAdisyonAc(a);
                                sonuc = r.RezervasyonAc(r); ;

                                masa.setChangeTableState(txtMasaNo.Text, 3);
                                if (sonuc)
                                {
                                    MessageBox.Show("Rezervasyon başarıyla gerçekleşmiştir.");
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Rezervasyon kayıdı gerçekleşememiştir, lütfen yetkili ile iletişime geçiniz.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon yapılan masa doludur.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Lütfen kişi sayısını giriniz.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir tarih seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Bu müşteri üzerine açık bir rezervasyon bulunmaktadır.");
                }
            }
        }

        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 23;
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtTarih.Value.ToString();
        }

        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text = cbKisiSayisi.SelectedItem.ToString();
        }

        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKisiSayisi.Enabled = true;
            txtMasa.Text = cbMasa.SelectedItem.ToString();

            cMasalar kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapasite = kapasitesi.KAPASITE;
            txtMasaNo.Text = Convert.ToString(kapasitesi.ID);

            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapasite; i++)
            {
                cbKisiSayisi.Items.Add(i + 1);
            }
        }

        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 305;
            
        }

        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbMasa.Width = 23;
        }

        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 23;
        }

        private void cbKisiSayisi_MouseEnter(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 100;
        }

        private void btnRezervasyonKontrol_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme frm = new frmMusteriEkleme();
            cGenel._musteriEkleme = 0;
            frm.btnMusteriGuncelle.Visible = false ;
            frm.label8.Visible = false;
            frm.btnYeniMusteri.Visible = true;
         
            this.Close();
            frm.Show();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {
                frmMusteriEkleme me = new frmMusteriEkleme();
                cGenel._musteriEkleme = 0;
                cGenel._musteriId = Convert.ToInt32((lvMusteriler.SelectedItems[0].SubItems[0].Text));
                me.btnMusteriGuncelle.Visible = true;
                me.btnYeniMusteri.Visible = false;
                me.label6.Visible = false;
                this.Close();
                me.Show();

            }        
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
    }
}
