
namespace CafeOtomasyonu.MENU
{
    partial class frmMutfak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMutfak));
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGidaListesi = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUrun = new System.Windows.Forms.Panel();
            this.txtGidaFiyatı = new System.Windows.Forms.TextBox();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.panelAnakategori = new System.Windows.Forms.Panel();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.rbAltKategori = new System.Windows.Forms.RadioButton();
            this.rbAnaKategori = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelUrun.SuspendLayout();
            this.panelAnakategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2});
            this.lvKategoriler.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.HideSelection = false;
            this.lvKategoriler.Location = new System.Drawing.Point(200, 306);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(320, 196);
            this.lvKategoriler.TabIndex = 0;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 2;
            this.columnHeader5.Text = "TurId";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Kategori";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Açıklama";
            this.columnHeader2.Width = 213;
            // 
            // lvGidaListesi
            // 
            this.lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGidaListesi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvGidaListesi.FullRowSelect = true;
            this.lvGidaListesi.GridLines = true;
            this.lvGidaListesi.HideSelection = false;
            this.lvGidaListesi.Location = new System.Drawing.Point(281, 306);
            this.lvGidaListesi.Name = "lvGidaListesi";
            this.lvGidaListesi.Size = new System.Drawing.Size(327, 196);
            this.lvGidaListesi.TabIndex = 1;
            this.lvGidaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGidaListesi.View = System.Windows.Forms.View.Details;
            this.lvGidaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGidaListesi_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UrunTurNo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Urun Adı";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyatı";
            this.columnHeader8.Width = 85;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::CafeAutomation.Properties.Resources.add;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnEkle.Location = new System.Drawing.Point(200, 184);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 79);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnDegistir.BackgroundImage = global::CafeAutomation.Properties.Resources.change;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDegistir.ForeColor = System.Drawing.Color.Transparent;
            this.btnDegistir.Location = new System.Drawing.Point(300, 184);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(95, 79);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Transparent;
            this.btnBul.BackgroundImage = global::CafeAutomation.Properties.Resources.findaddition;
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBul.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBul.ForeColor = System.Drawing.Color.Transparent;
            this.btnBul.Location = new System.Drawing.Point(399, 184);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(95, 79);
            this.btnBul.TabIndex = 2;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::CafeAutomation.Properties.Resources.delete;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnSil.Location = new System.Drawing.Point(499, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 79);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gıda Kategorisi :";
            // 
            // panelUrun
            // 
            this.panelUrun.BackColor = System.Drawing.Color.Transparent;
            this.panelUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelUrun.Controls.Add(this.txtGidaFiyatı);
            this.panelUrun.Controls.Add(this.txtGidaAdi);
            this.panelUrun.Controls.Add(this.cbKategoriler);
            this.panelUrun.Controls.Add(this.label3);
            this.panelUrun.Controls.Add(this.label2);
            this.panelUrun.Controls.Add(this.label1);
            this.panelUrun.Controls.Add(this.txtUrunId);
            this.panelUrun.ForeColor = System.Drawing.Color.Transparent;
            this.panelUrun.Location = new System.Drawing.Point(57, 30);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(349, 116);
            this.panelUrun.TabIndex = 5;
            // 
            // txtGidaFiyatı
            // 
            this.txtGidaFiyatı.Location = new System.Drawing.Point(145, 66);
            this.txtGidaFiyatı.Name = "txtGidaFiyatı";
            this.txtGidaFiyatı.Size = new System.Drawing.Size(183, 20);
            this.txtGidaFiyatı.TabIndex = 6;
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(145, 41);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(183, 20);
            this.txtGidaAdi.TabIndex = 6;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(145, 11);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(183, 21);
            this.cbKategoriler.TabIndex = 5;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gıda Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gıda Adı :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(331, 41);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(14, 20);
            this.txtUrunId.TabIndex = 7;
            // 
            // panelAnakategori
            // 
            this.panelAnakategori.BackColor = System.Drawing.Color.Transparent;
            this.panelAnakategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelAnakategori.Controls.Add(this.txtKategoriID);
            this.panelAnakategori.Controls.Add(this.txtAciklama);
            this.panelAnakategori.Controls.Add(this.txtKategoriAd);
            this.panelAnakategori.Controls.Add(this.label5);
            this.panelAnakategori.Controls.Add(this.label6);
            this.panelAnakategori.ForeColor = System.Drawing.Color.Transparent;
            this.panelAnakategori.Location = new System.Drawing.Point(431, 30);
            this.panelAnakategori.Name = "panelAnakategori";
            this.panelAnakategori.Size = new System.Drawing.Size(349, 116);
            this.panelAnakategori.TabIndex = 8;
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(330, 16);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(14, 20);
            this.txtKategoriID.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(142, 41);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(183, 20);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(142, 16);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(183, 20);
            this.txtKategoriAd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kategori Adı :";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(411, 159);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(183, 20);
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(200, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aramak İstediğiniz Ürün :";
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
            this.btnCikis.Location = new System.Drawing.Point(78, 495);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 43);
            this.btnCikis.TabIndex = 15;
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
            this.btnGeriDon.Location = new System.Drawing.Point(28, 495);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(45, 43);
            this.btnGeriDon.TabIndex = 16;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // rbAltKategori
            // 
            this.rbAltKategori.AutoSize = true;
            this.rbAltKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAltKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbAltKategori.Location = new System.Drawing.Point(296, 4);
            this.rbAltKategori.Name = "rbAltKategori";
            this.rbAltKategori.Size = new System.Drawing.Size(106, 24);
            this.rbAltKategori.TabIndex = 17;
            this.rbAltKategori.TabStop = true;
            this.rbAltKategori.Text = "Ürün Ekle";
            this.rbAltKategori.UseVisualStyleBackColor = false;
            this.rbAltKategori.CheckedChanged += new System.EventHandler(this.rbAltKategori_CheckedChanged);
            // 
            // rbAnaKategori
            // 
            this.rbAnaKategori.AutoSize = true;
            this.rbAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAnaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbAnaKategori.Location = new System.Drawing.Point(411, 4);
            this.rbAnaKategori.Name = "rbAnaKategori";
            this.rbAnaKategori.Size = new System.Drawing.Size(178, 24);
            this.rbAnaKategori.TabIndex = 18;
            this.rbAnaKategori.TabStop = true;
            this.rbAnaKategori.Text = "Ürün Kategori Ekle";
            this.rbAnaKategori.UseVisualStyleBackColor = false;
            this.rbAnaKategori.CheckedChanged += new System.EventHandler(this.rbAnaKategori_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(227, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ekle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(314, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Değiştir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(427, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bul";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(530, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sil";
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeAutomation.Properties.Resources.ARKAPLAN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbAnaKategori);
            this.Controls.Add(this.rbAltKategori);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelAnakategori);
            this.Controls.Add(this.panelUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvKategoriler);
            this.Controls.Add(this.lvGidaListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.panelAnakategori.ResumeLayout(false);
            this.panelAnakategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvGidaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.TextBox txtGidaFiyatı;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Panel panelAnakategori;
        private System.Windows.Forms.TextBox txtKategoriID;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.RadioButton rbAltKategori;
        private System.Windows.Forms.RadioButton rbAnaKategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}