using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CafeOtomasyonu.Classes
{
    class cAdisyon

    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion

        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into ADISYON(SERVISTURNO,TARIH,PERSONELID,MASAID,DURUM) values (@ServisTurNo,@Tarih,@PersonelID,@MasaId,@Durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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
        //Adisyon bilgisini getir metodu
        public int getByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from ADISYON where MASAID=@MasaId order by ID desc", con);
            //parametreyi gönderiyoruz
            cmd.Parameters.Add("MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Close();
            }
            return MasaId;
        }//açık olan masanın adisyon numarası

        public void adisyonkapat(int adisyonID, int durum)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update ADISYON set DURUM=@durum where ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonID;
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

        }

        public int paketAdisyonIdbulAdedi()
        {
            int miktar = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) as Sayi from ADISYON where (DURUM=0) and (SERVISTURNO=2)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                miktar = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return miktar;
        }

        public void acikPaketAdisyonlar(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PAKETSIPARIS.MUSTERIID,MUSTERILER.AD + ' ' + MUSTERILER.SOYAD as Musteri, ADISYON.ID as AdisyonID  FROM PAKETSIPARIS inner join MUSTERILER on MUSTERILER.ID=PAKETSIPARIS.MUSTERIID inner join ADISYON on ADISYON.ID=PAKETSIPARIS.ADISYONID where ADISYON.DURUM=0", con);

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
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Musteri"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AdisyonID"].ToString());

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

        public int musterininsonadisyonId(int musteriId)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select ADISYON.ID from ADISYON inner join PAKETSIPARIS on PAKETSIPARIS.ADISYONID=ADISYON.ID where PAKETSIPARIS.DURUM=0 and ADISYON.DURUM=0 and PAKETSIPARIS.MUSTERIID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());

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

        public void musteriDetaylar(ListView lv, int musteriId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PAKETSIPARIS.MUSTERIID,PAKETSIPARIS.ADISYONID,MUSTERILER.AD,MUSTERILER.SOYAD,CONVERT(varchar(10),ADISYON.TARIH,104) as tarih from ADISYON inner join PAKETSIPARIS on PAKETSIPARIS.ADISYONID=ADISYON.ID inner join MUSTERILER on MUSTERILER.ID=PAKETSIPARIS.MUSTERIID where ADISYON.SERVISTURNO=2  and PAKETSIPARIS.MUSTERIID=@musteriId", con);

            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int sayac = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["tarih"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADISYONID"].ToString());

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

        public int RezervasyonAdisyonAc(cAdisyon bilgiler)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into ADISYON(SERVISTURNO,TARIH,PERSONELID,MASAID) values (@ServisTurNo,@Tarih,@PersonelID,@MasaId); select scope_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = bilgiler.MasaId;

                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
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
    }
}

