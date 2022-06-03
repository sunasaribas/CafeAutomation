using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace CafeOtomasyonu.Classes
{
    class cPaketler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _Paytypeid;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int Paytypeid { get => _Paytypeid; set => _Paytypeid = value; }

        #endregion

        // paket servisi ekleme
        public bool OrderServiceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into PAKETSIPARIS (ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA) values (@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = order.AdditionID;
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order.ClientId;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order.Paytypeid;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order.Description;
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
        //paket servis işlemi kapatma
        public void OrderServiceClose(int AdditionID)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update PAKETSIPARIS set PAKETSIPARIS.DURUM=1 where PAKETSIPARIS.ADISYONID=@AdditionID)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value = AdditionID;
                Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        //Açılan adisyon ve paket  siparişe ait ön girilen ödeme tür id
        public int OdemeTurIdGetir(int adisyonId)
        {
            int odemeTurID = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PAKETSIPARIS.ODEMETURID from PAKETSIPARIS inner join ADISYON on PAKETSIPARIS.ADISYONID=ADISYON.ID where ADISYON.ID=@adisyonId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                odemeTurID = Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeTurID;
        }
        //sipariş kontrol için müşteriye ait açık olan en son adisyon nosunu getirir.
        //bir müşteriye ait 2 tane siparişin açık olamayacağını belirtiyoruz.
        public int musteriSonAdisyonIdGetir(int musteriID)
        {

            int no = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select ADISYON.ID from ADISYON inner join PAKETSIPARIS on PAKETSIPARIS.ADISYONID=ADISYON.ID where (ADISYON.DURUM=0) and (PAKETSIPARIS.DURUM=0) and PAKETSIPARIS.MUSTERIID=@musteriID)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;
                no = Convert.ToInt32(cmd.ExecuteScalar());
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
            return no;

        }
        //müşteri arama ekranında  adisyonbul butonu açık mı değil mi kontrol
        public bool getCheckOpenAdditionID(int additionID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from ADISYON where (DURUM=0) and (ID=@additionID)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionID", SqlDbType.Int).Value = additionID;

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


    }
}
