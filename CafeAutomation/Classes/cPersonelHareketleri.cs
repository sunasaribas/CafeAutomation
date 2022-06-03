using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace CafeOtomasyonu
{
    class cPersonelHareketleri
    {
        cGenel gnl = new cGenel();
        #region Field
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        #endregion


        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);

            //@ işareti dışarıdan parametre alacağım anlamına geliyor.Daha güvenli daha kolay olması açısından ph verdik  ilk cmdye sonra sql command bloguna gelecek
            SqlCommand cmd = new SqlCommand("Insert into PERSONELHAREKETLERI(PERSONELID,ISLEM,TARIH) values(@personelId,@islem,@tarih)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = ph._PersonelId;
                cmd.Parameters.Add("@islem", SqlDbType.VarChar).Value = ph._Islem;
                cmd.Parameters.Add("@tarih", SqlDbType.Date).Value = ph._Tarih;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
    }
}
