using CafeOtomasyonu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CafeOtomasyonu.MENU
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

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
        private void Istatistik(string gfName, int KatId, Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatisklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, KatId);
            gbIstatistik.Text = gfName;

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text);
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Gösterilecek istatistik yok, farklı bir zaman dilimi seçiniz.");
            }
        }
      
        private void btnCorba_Click(object sender, EventArgs e)
        {
            Istatistik("Çorba Grafiği", 1, Color.Yellow);
        }
        private void btnAraSicaklar_Click(object sender, EventArgs e)
        {
            Istatistik("Ara Sıcak Grafiği", 2, Color.Goldenrod);
        }
        private void btnAnayemek_Click(object sender, EventArgs e)
        {
            Istatistik("Anayemekler Grafiği", 3, Color.Red);
        }
        private void btnMakarna_Click(object sender, EventArgs e)
        {
            Istatistik("Makarna Grafiği", 4, Color.Purple);
        }
        private void btnFastFood_Click(object sender, EventArgs e)
        {
            Istatistik("Fast Food Grafiği", 5, Color.LightBlue);
        }
        private void btnSalata_Click(object sender, EventArgs e)
        {
            Istatistik("Salata Grafiği", 6, Color.Green);
        }
        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            Istatistik("Tatlılar Grafiği", 7, Color.Blue);
        }
        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği", 8, Color.Orange);
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.GreenYellow;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatisklereGore(lvIstatistik, dtBaslangic, dtBitis);
            gbIstatistik.Text = "TÜM ÜRÜNLER";

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text);
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Gösterilecek istatistik yok, farklı bir zaman dilimi seçiniz.");
            }
        }
    }
}
