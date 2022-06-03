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
    public partial class frmBill : Form
    {
        public frmBill()
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
        
        cSiparis cs = new cSiparis(); int odemeTuru = 0;
       
        private void frmBill_Load(object sender, EventArgs e)
        {
         
            if (cGenel._ServisTurNo==1)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirim.TextChanged +=new  EventHandler(txtIndirim_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count>0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
              
                if (chkIndirim.Checked)
                    gbIndirim.Visible = true;
                else
                    gbIndirim.Visible = false;
                txtIndirim.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                odemeTuru = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirim.TextChanged += new EventHandler(txtIndirim_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                //Ödeme türünün check eden döngü
                if (odemeTuru == 1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTuru == 2)
                {
                    rbKrediKarti.Checked = true;
                }
                else if (odemeTuru == 3)
                {
                    rbTicket.Checked = true;
                }

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                if (chkIndirim.Checked)
                    gbIndirim.Visible = true;
                else
                    gbIndirim.Visible = false;
                txtIndirim.Clear();
            }
        }

        private void txtIndirim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirim.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirim.Text));
                    }
                    catch (Exception)
                    {

                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim tutarı toplam tutardan fazla olamaz!");
                }
            }
            catch (Exception)
            {

                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }
        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirim.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirim.Clear();
            }
        }
        //25. ders indirim hesabı ile ödenecek tutar bulma
        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text)>0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }
        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo==1)
            {
                int masaid = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriId = 0;

                if (masalar.TableGetbyState(masaid,4)==true) //rezervasyonu var mı yok mu ona bakıoyruz
                {
                    musteriId = rezerve.getByClientIdFromRezervasyon(masaid);
                }
                else 
                {
                    musteriId = 1;//standart musterı
                }
                int odemeTurId = 0;

                if (rbNakit.Checked)
                {
                    odemeTurId =1;

                }
                if (rbKrediKarti.Checked)
                {
                    odemeTurId = 2;
                }
                if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }
                cOdeme odeme = new cOdeme();
                //ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM
                odeme.AdisyonID= Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap kapatılmıştır!");
                    masalar.setChangeTableState(Convert.ToString(masaid), 1);
                    cRezervasyon c = new cRezervasyon();
                    c.rezervationclose(Convert.ToInt32(lblAdisyonId.Text));
                    cAdisyon a = new cAdisyon();
                    a.adisyonkapat(Convert.ToInt32(lblAdisyonId.Text), 0);

                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("Hesap kapatılırken bir hata oluştu.Lütfen yetkililere bildiriniz");
                }
                
            }
            ////Paket sipariş
            else if(cGenel._ServisTurNo == 2)
            {

                cOdeme odeme = new cOdeme();
                //ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTuru;
                odeme.MusteriId = 1; //paket sipariş id
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap kapatılmıştır!");


                    cAdisyon a = new cAdisyon();
                    a.adisyonkapat(Convert.ToInt32(lblAdisyonId.Text), 1);



                    cPaketler p = new cPaketler();
                    p.OrderServiceClose((Convert.ToInt32(lblAdisyonId.Text)));


                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap kapatılırken bir hata oluştu.Lütfen yetkililere bildiriniz");
                }
            }
        }
        // Hesap özeti pdf şeklinde yazdırma kısmı
        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
     
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Kaktüs Cafe", Baslik, sb, 350, 100, st);
            e.Graphics.DrawString("-------------------", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı                         Adet         Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("---------------------------------------------------------", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı   :----------" + lblIndirim.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı       :----------" + lblKdv.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar     :----------" + lblToplamTutar + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödediğiniz Tutar :----------" + lblOdenecek + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 4), st);

        }

        private void lblAdisyonId_Click(object sender, EventArgs e)
        {

        }
    }
}
