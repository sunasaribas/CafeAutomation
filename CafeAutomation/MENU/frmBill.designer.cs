
namespace CafeOtomasyonu.MENU
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.label1 = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siparişler";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(21, 62);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(382, 177);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunId";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkIndirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(429, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(6, 50);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(162, 28);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.txtIndirim);
            this.gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbIndirim.ForeColor = System.Drawing.Color.White;
            this.gbIndirim.Location = new System.Drawing.Point(635, 62);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(200, 100);
            this.gbIndirim.TabIndex = 3;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel Aktivite";
            this.gbIndirim.Visible = false;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(7, 54);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(187, 29);
            this.txtIndirim.TabIndex = 0;
            this.txtIndirim.Visible = false;
            this.txtIndirim.TextChanged += new System.EventHandler(this.txtIndirim_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblOdenecek);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblIndirim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 178);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "TL";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(142, 139);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(21, 24);
            this.lblOdenecek.TabIndex = 6;
            this.lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(142, 102);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(21, 24);
            this.lblToplamTutar.TabIndex = 5;
            this.lblToplamTutar.Text = "0";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(142, 66);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(21, 24);
            this.lblKdv.TabIndex = 4;
            this.lblKdv.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(142, 31);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(21, 24);
            this.lblIndirim.TabIndex = 3;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ara Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "KDV";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İndirim";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.rbKrediKarti);
            this.groupBox4.Controls.Add(this.rbNakit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(328, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 135);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(6, 90);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(84, 28);
            this.rbTicket.TabIndex = 0;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 28);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nakit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(6, 63);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(124, 28);
            this.rbKrediKarti.TabIndex = 0;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(7, 29);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(74, 28);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
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
            this.btnCikis.Location = new System.Drawing.Point(81, 467);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(53, 50);
            this.btnCikis.TabIndex = 10;
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
            this.btnGeriDon.Location = new System.Drawing.Point(22, 467);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(53, 50);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapOzeti.BackgroundImage = global::CafeAutomation.Properties.Resources.paymentsum;
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.Location = new System.Drawing.Point(559, 217);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(102, 80);
            this.btnHesapOzeti.TabIndex = 12;
            this.btnHesapOzeti.UseVisualStyleBackColor = false;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapKapat.BackgroundImage = global::CafeAutomation.Properties.Resources.paymentoff;
            this.btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapKapat.Location = new System.Drawing.Point(559, 319);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(102, 80);
            this.btnHesapKapat.TabIndex = 12;
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(667, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hesap Özeti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(667, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hesap Kapat";
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdisyonId.ForeColor = System.Drawing.Color.Red;
            this.lblAdisyonId.Location = new System.Drawing.Point(140, 21);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(29, 24);
            this.lblAdisyonId.TabIndex = 15;
            this.lblAdisyonId.Text = "ID";
            this.lblAdisyonId.Click += new System.EventHandler(this.lblAdisyonId_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeAutomation.Properties.Resources.ARKAPLAN;
            this.ClientSize = new System.Drawing.Size(852, 544);
            this.Controls.Add(this.lblAdisyonId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Ödeme";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}