﻿using CafeOtomasyonu.Classes;
using CafeOtomasyonu.MENU;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void lblMasaNo_Click(object sender, EventArgs e)
        {

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
        //hesap islem metodu
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Sayı Gir");
                    break;
            }
        }

        int tableId, AdditionId;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = cGenel._ButtonValue;
            cMasalar ms = new cMasalar();
            tableId = ms.TableGetbyNumber(cGenel._ButtonName);

            if (ms.TableGetbyState(tableId, 2) == true || (ms.TableGetbyState(tableId, 4) == true))
            {
                cAdisyon Ad = new cAdisyon();
                AdditionId = Ad.getByAddition(tableId);
                cSiparis orders = new cSiparis();
                orders.getByOrder(lvSiparisler, AdditionId);
            }

            #region butonclicks
            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
            #endregion
        }
        cUrunCesitleri Uc = new cUrunCesitleri();

        private void btnAnayemek3_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnAnayemek3);
        }

        private void btnIcecekler8_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnIcecekler8);
        }

        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnTatlilar7);
        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnSalata6);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnFastFood5);
        }

        private void btnCorba1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnCorba1);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnMakarna4);
        }

        private void btnAraSicaklar2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnAraSicaklar2);
        }

        int sayac = 0, sayac2 = 0;
        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparisler.Items.Count > 0)
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {
                    cSiparis saveOrder = new cSiparis();
                    saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
            }
            lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
        }
        ArrayList silinenler = new ArrayList();

        // 4 adet durummuz var, sipariş butonuna tıklandığında masaların durumu değişiyor ve adisyon, satış tablolarına kaydediliyor.
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            /*Masa boş
             * Masa dolu
             * Masa rezerve
             * Dolu rezerve
             */
            cMasalar masa = new cMasalar();
            frmMasalar frms = new frmMasalar();
            cAdisyon newAddition = new cAdisyon();
            cSiparis saveOrder = new cSiparis();

            bool sonuc = false;

            if (masa.TableGetbyState(tableId, 1) == true)
            {
                newAddition.ServisTurNo = 1;
                
                newAddition.PersonelId = 1;
                newAddition.MasaId = tableId;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAdditionNew(newAddition);
                masa.setChangeTableState(cGenel._ButtonName, 2);

                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonID = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    frms.Show();
                }
            }
            else if (masa.TableGetbyState(tableId, 2) == true || masa.TableGetbyState(tableId, 4) == true)
            {

                if (lvYeniEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                        saveOrder.AdisyonID = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }

                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                frms.Show();
            }
            else if (masa.TableGetbyState(tableId, 3) == true)
            {
                /*
                newAddition.ServisTurNo = 1;
                newAddition.PersonelId = 1;
                newAddition.MasaId = tableId;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAdditionNew(newAddition);
                 */

                masa.setChangeTableState(cGenel._ButtonName, 4);
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonID = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    frms.Show();
                }

            }
        }


        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }

            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lvYeniEklenenler.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lvYeniEklenenler.Items.Add(AdditionId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(tableId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;

                txtAdet.Text = "";
            }
        }



        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text=="")
            {
                txtAra.Text = "";
            }
            else
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.getByProductSearch(lvMenu, Convert.ToInt32(txtAra.Text));
            }
            
        }
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            cGenel._ServisTurNo = 1;
            cGenel._AdisyonId = AdditionId.ToString();
            frmBill frm = new frmBill();
            this.Close();
            frm.Show();
        }

    }
}

