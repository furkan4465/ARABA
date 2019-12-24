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
        public bool ArabaEkle(Araba araba)
        {
            SqlParameter[] p = { new SqlParameter("@Kategori_adi", araba.Kategori_adi), new SqlParameter("Ust_Kategori_id", araba.Ust_Kategori_id) };
            return 0 < help.ExecuteNonQuery("INSERT INTO marka (Kategori_adi,Ust_Kategori_id) VALUES(@Kategori_adi,@Ust_Kategori_id)", p);
        }

        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
}
