using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOtomasyonu.Classes
{
    class cRezervasyon
    {
        #region Fields
        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _ClientCount;
        private string _Description;
        private int _AdditionId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _TableId; set => _TableId = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int ClientCount { get => _ClientCount; set => _ClientCount = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; }
        #endregion

        cGenel gnl = new cGenel();

        //MüşteriID masa numarasına göre 
        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 1 MUSTERIID from REZERVASYONLAR where MASAID=@masaid order by MUSTERIID desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("masaid", SqlDbType.Int).Value = tableId;
                clientId = Convert.ToInt32(cmd.ExecuteScalar());
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

            return clientId;
        }

        //Hesap kapatırken rezervasyonlu masayı kapattık
        public bool rezervationclose(int adisyonID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update REZERVASYONLAR set DURUM=1 where ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonID;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

            return result;

        }
        //MREZERVASYONLARI GETIR
        public void musteriIdGetirFromRezervasyon(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select REZERVASYONLAR.MUSTERIID,( AD+SOYAD) AS MUSTERI FROM REZERVASYONLAR INNER JOIN MUSTERILER ON REZERVASYONLAR.MUSTERIID=MUSTERILER.ID WHERE REZERVASYONLAR.DURUM=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["MUSTERI"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        //ESKİ REZERVASYONLARI GETIR
        public void eskiRezervasyonlarıGetir(ListView lv, int mId)
        {
            lv.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select REZERVASYONLAR.MUSTERIID,AD,SOYAD,ADISYONID,TARIH FROM REZERVASYONLAR INNER JOIN MUSTERILER ON REZERVASYONLAR.MUSTERIID=MUSTERILER.ID WHERE REZERVASYONLAR.MUSTERIID=@mId and REZERVASYONLAR.DURUM=0 order by REZERVASYONLAR.ID DESC", conn);

            comm.Parameters.Add("mId", SqlDbType.Int).Value = mId;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["TARIH"].ToString());
                lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        //EN SON REZERVASYON TARIHINI GETIR
        public DateTime EnSonRezervasyonTarihi(int mId)
        {
            DateTime tar = new DateTime();
            tar = DateTime.Now;

            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select TARIH FROM REZERVASYONLAR WHERE REZERVASYONLAR.MUSTERIID=@mId and REZERVASYONLAR.DURUM=1 order by REZERVASYONLAR.ID DESC", conn);

            comm.Parameters.Add("mId", SqlDbType.Int).Value = mId;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            tar = Convert.ToDateTime(comm.ExecuteScalar());

            conn.Dispose();
            conn.Close();

            return tar;
        }
        //AÇIK REZERVASYONLARI SAYISI GETİR
        public int acikRezervasyonSayisi()
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select count(*) FROM REZERVASYONLAR  WHERE REZERVASYONLAR.DURUM=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                sonuc = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            conn.Dispose();
            conn.Close();

            return sonuc;
        }
        //REZERVASYON ACIK MI KONTROLU
        public bool RezervasyonAcikmiKontrol(int mId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 1 REZERVASYONLAR.ID FROM REZERVASYONLAR WHERE MUSTERIID=@mId and DURUM=1 ORDER BY ID DESC", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

            return result;

        }
        //REZERVASYON AÇ
        public bool RezervasyonAc(cRezervasyon r)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into REZERVASYONLAR (MUSTERIID,MASAID,ADISYONID,KISISAYISI,TARIH,ACIKLAMA,DURUM) VALUES (@MUSTERIID,@MASAID,@ADISYONID,@KISISAYISI,@TARIH,@ACIKLAMA,1)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = r.ClientId;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = r.TableId;
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = r.AdditionId;
                cmd.Parameters.Add("@KISISAYISI", SqlDbType.Int).Value = r.ClientCount;
                cmd.Parameters.Add("@TARIH", SqlDbType.Date).Value = r.Date;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = r.Description;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

            return result;

        }
        //REZERVE MASANIN ID SİNİ GETİR
        public int RezerverMasaIdGetir(int mId)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select REZERVASYONLAR.MASAID FROM REZERVASYONLAR INNER JOIN ADISYON ON REZERVASYONLAR.ADISYONID = ADISYON.ID WHERE REZERVASYONLAR.DURUM=1 AND  ADISYON.DURUM=0 AND REZERVASYONLAR.MUSTERIID=@mId ", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                comm.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
                sonuc = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            conn.Dispose();
            conn.Close();

            return sonuc;
        }

    }
}
