
namespace CafeOtomasyonu.MENU
{
    partial class frmSiparisKontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisKontrol));
            this.lvMusteriDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToplamTutasr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblSonSiparisTarihi = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMusteriDetaylari
            // 
            this.lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriDetaylari.FullRowSelect = true;
            this.lvMusteriDetaylari.HideSelection = false;
            this.lvMusteriDetaylari.Location = new System.Drawing.Point(221, 10);
            this.lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            this.lvMusteriDetaylari.Size = new System.Drawing.Size(345, 394);
            this.lvMusteriDetaylari.TabIndex = 0;
            this.lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            this.lvMusteriDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvMusteriDetaylari_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Ad";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Soyad";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adisyon ID";
            this.columnHeader5.Width = 0;
            // 
            // lvSatisDetaylari
            // 
            this.lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSatisDetaylari.FullRowSelect = true;
            this.lvSatisDetaylari.HideSelection = false;
            this.lvSatisDetaylari.Location = new System.Drawing.Point(571, 10);
            this.lvSatisDetaylari.Name = "lvSatisDetaylari";
            this.lvSatisDetaylari.Size = new System.Drawing.Size(252, 240);
            this.lvSatisDetaylari.TabIndex = 1;
            this.lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.DisplayIndex = 3;
            this.columnHeader12.Text = "SatisId";
            this.columnHeader12.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 0;
            this.columnHeader6.Text = "Ürün Ad";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 1;
            this.columnHeader7.Text = "Adet";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "Fiyat";
            this.columnHeader8.Width = 90;
            // 
            // txtToplamTutasr
            // 
            this.txtToplamTutasr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtToplamTutasr.Location = new System.Drawing.Point(393, 410);
            this.txtToplamTutasr.Multiline = true;
            this.txtToplamTutasr.Name = "txtToplamTutasr";
            this.txtToplamTutasr.ReadOnly = true;
            this.txtToplamTutasr.Size = new System.Drawing.Size(187, 30);
            this.txtToplamTutasr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(391, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(338, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genel Toplam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(333, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "En Son Sipariş:";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblToplamSiparis.ForeColor = System.Drawing.Color.Black;
            this.lblToplamSiparis.Location = new System.Drawing.Point(482, 458);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(98, 24);
            this.lblToplamSiparis.TabIndex = 4;
            this.lblToplamSiparis.Text = "________";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.ForeColor = System.Drawing.Color.Red;
            this.lblGenelToplam.Location = new System.Drawing.Point(482, 493);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(98, 24);
            this.lblGenelToplam.TabIndex = 5;
            this.lblGenelToplam.Text = "________";
            // 
            // lblSonSiparisTarihi
            // 
            this.lblSonSiparisTarihi.AutoSize = true;
            this.lblSonSiparisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblSonSiparisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSonSiparisTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblSonSiparisTarihi.Location = new System.Drawing.Point(482, 524);
            this.lblSonSiparisTarihi.Name = "lblSonSiparisTarihi";
            this.lblSonSiparisTarihi.Size = new System.Drawing.Size(98, 24);
            this.lblSonSiparisTarihi.TabIndex = 6;
            this.lblSonSiparisTarihi.Text = "________";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(585, 255);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(18, 24);
            this.lvMusteriler.TabIndex = 7;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MusteriId";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Musteri";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "AdisyonId";
            // 
            // btnCikis
            // 
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(75, 504);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 43);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.BackgroundImage")));
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(24, 504);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(45, 43);
            this.btnGeriDon.TabIndex = 13;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmSiparisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeAutomation.Properties.Resources.ARKAPLAN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 571);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.lblSonSiparisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamSiparis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutasr);
            this.Controls.Add(this.lvSatisDetaylari);
            this.Controls.Add(this.lvMusteriDetaylari);
            this.Name = "frmSiparisKontrol";
            this.Text = "Sipariş Kontrol";
            this.Load += new System.EventHandler(this.frmSiparisKontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtToplamTutasr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblSonSiparisTarihi;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}