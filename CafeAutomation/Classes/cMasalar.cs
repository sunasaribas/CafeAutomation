using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;
        private string _MASABILGI;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVISTURU { get => _SERVISTURU; set => _SERVISTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        public string MASABILGI { get => _MASABILGI; set => _MASABILGI = value; }
        #endregion

        cGenel gnl = new cGenel();
        private string masaNo;

        public string SessionSum(int state)
        {
            //Ders 12
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH,MASAID from ADISYON Join MASALAR on ADISYON.MASAID=MASALAR.ID where MASALAR.DURUM =" + state + " and ADISYON.Durum = 0", con);

            SqlDataReader dr = null;
            // cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString("yyyy-MM-dd HH:mm:ss");
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }
            return dt;

        }
        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }

        }

        //Masanın durumunu öğrenmek için yazdık, true false olarak döner. 2 ve 4 durumu önemli stateden kastımız otur.
        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM from MASALAR where ID=@TableId and DURUM=@state", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

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
            return result;
        }
        public void setChangeTableState(string ButonName, int state)//masa durumunu değiştir
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update MASALAR set DURUM=@Durum where ID=@MasaNo", con);
            string masaNo = "";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);

            if (uzunluk > 8)
            {
                masaNo = aa.Substring(uzunluk - 2, 2);
            }
            else
            {
                masaNo = aa.Substring(uzunluk - 2, 1);
            }


            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
        public void MasaKapasitesiveDurumuGetir(ComboBox cm)
        {
            cm.Items.Clear();
            string durum = "";

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from masalar", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar c = new cMasalar();
                if (c._DURUM == 2)
                    durum = "DOLU";
                else if (c._DURUM == 3)
                    durum = "REZERVE";
                c._KAPASITE = Convert.ToInt32(dr["KAPASITE"]);
                c._MASABILGI = "MASA NO" + dr["ID"].ToString() + "KAPASİTESİ :" + dr["KAPASITE"].ToString();
                c._ID = Convert.ToInt32(dr["ID"]);
                cm.Items.Add(c);


            }
            dr.Close();
            con.Dispose();
            con.Close();

        }

        public override string ToString()
        {
            return MASABILGI;
        }
    }
}

