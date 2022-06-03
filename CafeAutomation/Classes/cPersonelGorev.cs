using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CafeOtomasyonu.Classes
{
    class cPersonelGorev
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int personelGorevId;
        private string _tanim;
        #endregion
        #region Properties
        public int PersonelGorevId { get => personelGorevId; set => personelGorevId = value; }
        public string Tanim { get => _tanim; set => _tanim = value; }
        #endregion

        //comboboxun içine personelleri ve görevleri atadım
        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from PERSONELGOREVLERI", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cPersonelGorev c = new cPersonelGorev();
                    c.personelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["GOREV"].ToString();
                    cb.Items.Add(c);

                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }
        public string PersonelGorevTanım(int per)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select GOREV from PERSONELGOREVLERI where ID=@perId", con);
            cmd.Parameters.Add("perId", SqlDbType.Int).Value = per;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return sonuc;
        }

        //overload ettik yapmasaydık yapsaydık ne olacakTı?

        public override string ToString()
        {
            return _tanim;
        }

    }
}
