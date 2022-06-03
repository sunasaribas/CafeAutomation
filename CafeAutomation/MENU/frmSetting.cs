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
    public partial class frmSetting : Form
    {
        public frmSetting()
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

        private void frmSetting_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanım(cGenel._gorevId);
            if (gorev == "Müdür")
            {
                cp.personelGetbyInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetirLV(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = false;
                btnEkle.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki:Müdür / Yetki Sınırsız / Kullanıcı: " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki:Müdür / Yetki Sınırlı / Kullanıcı: " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" || txtYeniSifreTekrar.Text.Trim() != "")
            {

                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    if (txtPersonelId.Text != "")
                    {
                        cPersoneller c = new cPersoneller(); ;
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla gerçekleşmiştir!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel seçiniz!");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreeler aynı değil,lütfen tekrar deneyiniz.");

                }
            }
            else
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız!");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevID2.Text = Convert.ToString(c.PersonelGorevId);
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;
            txtPersonelId.Text = Convert.ToString(c.PersonelId);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnEkle.Enabled = true;
            btnBilgiDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silinmiştiir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Bir kayıt seçiniz.");
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" & txtSoyad.Text.Trim() != "" & txtSifre.Text.Trim() != "" & txtSifreTekrar.Text != "" & txtGorevID2.Text.Trim() != "")
            {
                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifre.Text;
                    c.PersonelGorevId = Convert.ToInt32(txtGorevID2.Text);
                    bool sonuc = c.personelEkle(c);

                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla eklenmiştir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil!");
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
            }
        }

        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {


                if (txtAd.Text != "" || txtSoyad.Text != "" || txtSifre.Text != "" || txtSifreTekrar.Text != "" || txtGorevID2.Text != "")
                {
                    if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifre.Text;
                        c.PersonelGorevId = Convert.ToInt32(txtGorevID2.Text);
                        bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelID2.Text));

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
                            c.personelBilgileriniGetirLV(lvPersoneller);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt güncellenirken bir hata oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler aynı değil!");
                    }
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Kayıt seçiniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" || textBox3.Text.Trim() != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller(); ;
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox2.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla gerçekleşmiştir!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel seçiniz!");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreeler aynı değil,lütfen tekrar deneyiniz.");

                }
            }
            else
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız!");
            }

        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                txtPersonelID2.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnSil.Enabled = false;
            }


        }


    }
}