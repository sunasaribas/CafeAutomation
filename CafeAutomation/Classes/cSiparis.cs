using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace CafeOtomasyonu.Classes
{
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion
        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int AdisyonID { get => _adisyonID; set => _adisyonID = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }
        #endregion

        //Siparisleri getir metod voidoldugu ıcın return kullanmadık
        public void getByOrder(ListView lv, int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT, SATISLAR.ID,URUNID,SATISLAR.ADET from SATISLAR inner join URUNLER on SATISLAR.URUNID=URUNLER.ID where ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                dr.Close();
                dr.Dispose();
                con.Close();
            }
        }
        //Siparişleri dbye yansıtma metodu
        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into SATISLAR(ADISYONID,URUNID,ADET,MASAID) values (@AdisyonNo,@UrunId,@Adet,@masaId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._adisyonID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._adet;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Bilgiler._masaId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;

        }
        //Adisyondan ürün silme
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from SATISLAR where ID=@SatisID", con);

            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public decimal GenelToplamBul(int musteriId)
        {
            decimal geneltoplam = 0;
            SqlConnection con = new SqlConnection(gnl.conString); //SQL de view kısmından yapıldı, kolay yazmak için güzel
            //SqlCommand cmd = new SqlCommand("SELECT  SUM(dbo.SATISLAR.ADET * FIYAT) AS Fiyat FROM  dbo.MUSTERILER INNER JOIN dbo.PAKETSIPARIS ON dbo.MUSTERILER.ID = dbo.PAKETSIPARIS.MUSTERIID INNER JOIN ADISYON on ADISYON.ID=PAKETSIPARIS.ADISYONID inner join dbo.SATISLAR ON dbo.ADISYON.ID = dbo.SATISLAR.ADISYONID INNER JOIN dbo.URUNLER ON dbo.SATISLAR.URUNID = dbo.URUNLER.ID WHERE(dbo.PAKETSIPARIS.MUSTERIID = @musteriId) AND(dbo.PAKETSIPARIS.DURUM = 0)", con);

            SqlCommand cmd = new SqlCommand("select SUM(TOPLAMTUTAR) from HESAPODEMELERI where MUSTERIID=@musteriId)", con);
            cmd.Parameters.Add("musteriId", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                geneltoplam = Convert.ToDecimal(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return geneltoplam;
        }

        public void adisyonpaketsiparisDetaylari(ListView lv, int adisyonID)
        {
            lv.Items.Clear();
            decimal geneltoplam = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select SATISLAR.ID as satisID SATIS ID,URUNLER.URUNAD,URUNLER.FIYAT,SATISLAR.ADET from SATISLAR inner join ADISYON on ADISYON.ID=SATISLAR.ADISYONID inner join URUNLER on URUNLER.ID =SATISLAR.URUNID where SATISLAR.ADISYONID=@adisyonID)", con);

            cmd.Parameters.Add("adisyonID", SqlDbType.Int).Value = adisyonID;
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["satisID"].ToString());
                    lv.Items[i].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                    i++;
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

        }
    }
}
