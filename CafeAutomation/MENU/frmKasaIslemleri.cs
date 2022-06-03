using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu.MENU
{
    public partial class frmKasaIslemleri : Form
    {
        public frmKasaIslemleri()
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

        private void frmKasaIslemleri_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter1.Fill(this.dataSet1.DataTable2);
            //TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dataSet1.DataTable1);

            this.rpvAylik.RefreshReport();
            this.rpvGunluk.RefreshReport();
            rpvGunluk.Visible = false;
            label3.Text = "AYLIK RAPOR";
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            label3.Text = "AYLIK RAPOR";
            rpvAylik.Visible = true;
            rpvGunluk.Visible = false;
        }

        private void btnZRapor_Click(object sender, EventArgs e)
        {
            label3.Text = "GÜNLÜK RAPOR";
            rpvAylik.Visible = false;
            rpvGunluk.Visible = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter1.FillBy(this.dataSet1.DataTable1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter1.FillBy(this.dataSet1.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
