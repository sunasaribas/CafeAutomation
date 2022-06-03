
namespace CafeOtomasyonu.MENU
{
    partial class frmKasaIslemleri
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaIslemleri));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CafeAutomation.DataSet1();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            this.btnZRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter1 = new CafeAutomation.DataSet1TableAdapters.DataTable1TableAdapter();
            this.dataTable2TableAdapter1 = new CafeAutomation.DataSet1TableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.BackgroundImage = global::CafeAutomation.Properties.Resources.statistics;
            this.btnAylikRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylikRapor.ForeColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.Location = new System.Drawing.Point(59, 89);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(149, 115);
            this.btnAylikRapor.TabIndex = 0;
            this.btnAylikRapor.UseVisualStyleBackColor = false;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // btnZRapor
            // 
            this.btnZRapor.BackgroundImage = global::CafeAutomation.Properties.Resources.zreport;
            this.btnZRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRapor.Location = new System.Drawing.Point(59, 269);
            this.btnZRapor.Name = "btnZRapor";
            this.btnZRapor.Size = new System.Drawing.Size(149, 115);
            this.btnZRapor.TabIndex = 1;
            this.btnZRapor.UseVisualStyleBackColor = true;
            this.btnZRapor.Click += new System.EventHandler(this.btnZRapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(54, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "AYLIK RAPOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(70, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Z RAPORU";
            // 
            // rpvAylik
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = null;
            this.rpvAylik.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvAylik.LocalReport.ReportEmbeddedResource = "CafeAutomation.Report1.rdlc";
            this.rpvAylik.Location = new System.Drawing.Point(273, 42);
            this.rpvAylik.Name = "rpvAylik";
            this.rpvAylik.ServerReport.BearerToken = null;
            this.rpvAylik.Size = new System.Drawing.Size(775, 440);
            this.rpvAylik.TabIndex = 6;
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
            this.btnCikis.Location = new System.Drawing.Point(118, 487);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(53, 50);
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
            this.btnGeriDon.Location = new System.Drawing.Point(59, 487);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(53, 50);
            this.btnGeriDon.TabIndex = 13;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(563, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "AYLIK RAPOR";
            // 
            // rpvGunluk
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DataTable2BindingSource;
            this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvGunluk.LocalReport.ReportEmbeddedResource = "CafeAutomation.Report2.rdlc";
            this.rpvGunluk.Location = new System.Drawing.Point(273, 42);
            this.rpvGunluk.Name = "rpvGunluk";
            this.rpvGunluk.ServerReport.BearerToken = null;
            this.rpvGunluk.Size = new System.Drawing.Size(761, 430);
            this.rpvGunluk.TabIndex = 15;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter1
            // 
            this.dataTable2TableAdapter1.ClearBeforeFill = true;
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeAutomation.Properties.Resources.ARKAPLAN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 562);
            this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.rpvAylik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZRapor);
            this.Controls.Add(this.btnAylikRapor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKasaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKasaIslemleri";
            this.Load += new System.EventHandler(this.frmKasaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private CafeAutomation.DataSet1 dataSet1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private CafeAutomation.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private CafeAutomation.DataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter1;
    }
}