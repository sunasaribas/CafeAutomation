using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace CafeOtomasyonu.Classes
{
    class cMusteriler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _musteriid;
        private string _musteriad;
        private string _musterisoyad;
        private string _telefon;
        private string _adres;
        private string _email;
        #endregion
        #region Properties
        public int Musteriid { get => _musteriid; set => _musteriid = value; }
        public string Musteriad { get => _musteriad; set => _musteriad = value; }
        public string Musterisoyad { get => _musterisoyad; set => _musterisoyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Adres { get => _adres; set => _adres = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion


        public bool MusteriVarmi(string tlf)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return sonuc;

        }

        public int musteriEkle(cMusteriler m)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into MUSTERILER (AD,SOYAD,TELEFON,ADRES,EMAIL) values (@ad,@soyad,@telefon,@adres,@email); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
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
        public bool musteriBilgileriGuncelle(cMusteriler m)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update MUSTERILER set AD=@ad,SOYAD=@soyad,TELEFON=@telefon,ADRES=@adres,EMAIL=@email where ID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
                cmd.Parameters.Add("@musteriId", SqlDbType.VarChar).Value = m.Musteriid;
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

        public void musterileriGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select*from MUSTERILER", con);

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
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        //musterileri id'ye göre getir metodu
        public void musterigetirID(int musteriId, TextBox ad, TextBox soyad, TextBox tlf, TextBox adres, TextBox email)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from MUSTERILER where ID=@musteriID", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("musteriID", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ad.Text = dr["AD"].ToString();
                    soyad.Text = dr["SOYAD"].ToString();
                    tlf.Text = dr["TELEFON"].ToString();
                    adres.Text = dr["ADRES"].ToString();
                    email.Text = dr["EMAIL"].ToString();
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
        //musterileri isme göre getir metodu
        public void musterigetirAd(ListView lv, string musteriAd)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from MUSTERILER where AD like @musteriAd + '%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("musteriAd", SqlDbType.VarChar).Value = musteriAd;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        //musterileri soyada göre getir metodu
        public void musterigetirSoyad(ListView lv, string musterisoyad)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from MUSTERILER where SOYAD like @musterisoyad + '%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("musterisoyad", SqlDbType.VarChar).Value = musterisoyad;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        //musterileri telefona göre getir metodu
        public void musterigetirTlf(ListView lv, string tlf)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from MUSTERILER where TELEFON like @tlf + '%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("tlf", SqlDbType.VarChar).Value = tlf;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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

