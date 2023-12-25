using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogretmen)
        {
            var hlp = new Helper();
            var p = new SqlParameter[] {
                new SqlParameter("@Ad", ogretmen.Ad),
                new SqlParameter("@Soyad",ogretmen.Soyad),
                new SqlParameter("@TcNo",ogretmen.TcNo)
            };
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values(@Ad,@Soyad,@TcNo)", p) > 0;
        }
    }
}