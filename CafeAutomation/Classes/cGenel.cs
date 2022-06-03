using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CafeOtomasyonu
{
    public class cGenel
    {
        public string conString = (@"Server=DESKTOP-FLOADJ7\SQLEXPRESS;Initial Catalog=CafeOtomasyonu;Integrated Security=True");
        public static int _personelId;
        public static int _gorevId;
        public static int _musteriEkleme;
        public static string _ButtonValue;
        public static int _musteriId;
        public static string _ButtonName;
        public static int _ServisTurNo;
        public static string _AdisyonId;
    }
}
