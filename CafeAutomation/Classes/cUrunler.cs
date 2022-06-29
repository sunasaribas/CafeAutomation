using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CafeOtomasyonu.Classes
{
    class cUrunler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _urunid;
        private int _urunturno;
        private string _urunad;
        private decimal _fiyat;
        private string _aciklama;
        private bool _durum;
        #endregion
        #region Properties
        public int Urunid { get => _urunid; set => _urunid = value; }
        public int Urunturno { get => _urunturno; set => _urunturno = value; }
        public string Urunad { get => _urunad; set => _urunad = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        public bool Durum { get => _durum; set => _durum = value; }
        #endregion
        //ürün adına göre listeleme
        public void urunleriListeleByUrunAdi(ListView lv, string urunadi)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select*from URUNLER where DURUM=0 and URUNAD like '&' + @urunAdi + '%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunAdi", SqlDbType.VarChar).Value = urunadi;
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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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
                con.Dispose();
                con.Close();
            }
        }
        //ürün ekle
        public int urunEkle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into URUNLER (URUNAD,KATEGORIID,ACIKLAMA,FIYAT,DURUM) values (@urunAd,@katId,@aciklama,@fiyat,@durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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
        //URUNLER VE KATEGORILERI LISTELE
        public void urunleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select URUNLER.*, KATEGORIADI from URUNLER inner join KATEGORILER on KATEGORILER.ID=URUNLER.KATEGORIID where URUNLER.DURUM=0", con);

            SqlDataReader dr = null;

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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());

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
                con.Dispose();
                con.Close();
            }
        }
        //urunleri guncelle
        public int urunGuncelle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update URUNLER set URUNAD=@urunad,KATEGORIID=@katID,ACIKLAMA=@aciklama,FIYAT=@fiyat where ID=@urunID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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
        //URUNLERİ SİL
        public int urunSil(cUrunler u, int kat)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);

            string sql = "Update URUNLER set DURUM=1 WHERE ";
            if (kat == 0)
            {
                sql += "KATEGORIID=@urunID";
            }
            else
            {
                sql += "ID=@urunID";
            }

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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
        //urunlerı ID göre listeleme
        public void urunleriListeleByUrunAdi(ListView lv, int urunId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select URUNLER.*, KATEGORIADI from URUNLER inner join KATEGORILER on KATEGORILER.ID=URUNLER.KATEGORIID where URUNLER.DURUM=0 and URUNLER.KATEGORIID=@urunID", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = urunId;
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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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
                con.Dispose();
                con.Close();
            }
        }
        //2 tarih arası butun urunlerı getırır
        public void urunleriListeleIstatisklereGore(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 10 URUNLER.URUNAD,SUM(SATISLAR.ADET) as adeti from KATEGORILER inner join URUNLER on KATEGORILER.ID=URUNLER.KATEGORIID inner join SATISLAR on URUNLER.ID=SATISLAR.URUNID inner join ADISYON on SATISLAR.ADISYONID=ADISYON.ID where (CONVERT(varchar,TARIH,104) between convert (varchar, @Baslangic ,104) and Convert(varchar,@Bitis,104)) group by URUNLER.URUNAD order by adeti desc", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToString(); ;
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
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());
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
                con.Dispose();
                con.Close();
            }
        }
        //belli kategorıye gore urunlerı listeler. 
        public void urunleriListeleIstatisklereGoreUrunId(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis, int urunkatId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 10 URUNLER.URUNAD,SUM(SATISLAR.ADET) as adeti from KATEGORILER inner join URUNLER on KATEGORILER.ID=URUNLER.KATEGORIID inner join SATISLAR on URUNLER.ID=SATISLAR.URUNID inner join ADISYON on SATISLAR.ADISYONID=ADISYON.ID where (CONVERT(varchar,TARIH,104) between convert (varchar,@Baslangic ,104) and Convert(varchar,@Bitis,104)) and(URUNLER.KATEGORIID=@katId) group by URUNLER.URUNAD order by adeti desc", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToString();
            cmd.Parameters.Add("@katId", SqlDbType.Int).Value = urunkatId;
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
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());
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
                con.Dispose();
                con.Close();
            }
        }


    }
}
