using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaBLL
{
    public class ArabaBL:IDisposable
    {
        Helper help = new Helper();

        public List<Araba> AracListele(int id)
        {
            List<Araba> marka = new List<Araba>();

            SqlParameter[] p = { new SqlParameter("@id", id) };

            SqlDataReader dr = help.ExecuteReader("SELECT Kategori_id,Kategori_adi,Ust_Kategori_id FROM marka WHERE Ust_Kategori_id=@id", p);

            while (dr.Read())
            {
                marka.Add
                (
                    new Araba
                    {
                        Kategori_id = (int)dr["Kategori_id"],
                        Kategori_adi = dr["Kategori_adi"].ToString(),
                        Ust_Kategori_id = (int)dr["Ust_Kategori_id"]
                    }
                );
            }
            dr.Close();

            marka.Insert(0, new Araba { Kategori_adi = "Seçiniz..." });
            return marka;
        }
        
        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
}
