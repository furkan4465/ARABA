using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ArabaBLL
{
    public class OzelliklerBL:IDisposable
    {
        Helper hlp = new Helper();

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

        public List<Ozellikler> Goruntule(int id)
        {
            List<Ozellikler> liste = new List<Ozellikler>();
            SqlParameter[] p = { new SqlParameter("@id", id) };
            SqlDataReader dr = hlp.ExecuteReader("select Tipi,Cekis,Motor,Beygir,Tork,YTüketimi,YTürü,SonHiz,Hizlanma,Yili,Arabaid from Ozellik where Arabaid =@id" ,p);

            while (dr.Read())
            {
                liste.Add(new Ozellikler
                {
                    Tipi = dr["Tipi"].ToString(),
                    Cekis = dr["Cekis"].ToString(),
                    Motor = (int)dr["motor"],
                    Beygir= (int)dr["Beygir"],
                    Tork = (int)dr["Tork"],
                    YTüketimi = float.Parse(dr["YTüketimi"].ToString()),
                    YTürü = dr["YTürü"].ToString(),
                    SonHiz = (int)dr["SonHiz"],
                    Hizlanma = float.Parse(dr["Hizlanma"].ToString()),
                    Yili = (int)dr["Yili"],

                });
            }
            dr.Close();
            return liste;
        }
        public List<Ozellikler> AracBilgileri()
        {

            try
            {
                List<Ozellikler> lst = new List<Ozellikler>();

                SqlParameter[] p = null;
                SqlDataReader dr = hlp.ExecuteReader("select Tipi,Cekis,Motor,Beygir,Tork,YTüketimi,YTürü,SonHiz,Hizlanma,Yili,Arabaid from Ozellik",p);

                while (dr.Read())
                {
                    lst.Add(new Ozellikler
                    {
                        Tipi = dr["Tipi"].ToString(),
                        Cekis = dr["Cekis"].ToString(),
                        Motor = (int)dr["motor"],
                        Beygir = (int)dr["Beygir"],
                        Tork = (int)dr["Tork"],
                        YTüketimi = float.Parse(dr["YTüketimi"].ToString()),
                        YTürü = dr["YTürü"].ToString(),
                        SonHiz = (int)dr["SonHiz"],
                        Hizlanma = float.Parse(dr["Hizlanma"].ToString()),
                        Yili = (int)dr["Yili"],

                    });
                    //arb.Yakit = Convert.ToInt32(dr["Yakit"]);
                    //arb.Vites = Convert.ToInt32(dr["Vites"]);
                    //arb.Cekis = Convert.ToInt32(dr["Cekis"]);
                    //arb.Kapi = Convert.ToInt32(dr["Kapi"]);
                    //arb.KasaTipi = Convert.ToInt32(dr["KasaTipi"]);

                    //lst.Add(arb);
                }
                dr.Close();
                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool OzellikKaydet(Ozellikler ozl)
        {
            SqlParameter[] p = 
                {
                new SqlParameter("@Tipi", ozl.Tipi),
                new SqlParameter("@Cekis", ozl.Cekis),
                new SqlParameter("@Motor", ozl.Motor),
                new SqlParameter("@Beygir", ozl.Beygir),
                new SqlParameter("@Tork", ozl.Tork),
                new SqlParameter("@YTüketimi", ozl.YTüketimi),
                new SqlParameter("@YTürü", ozl.YTürü),
                new SqlParameter("@SonHiz", ozl.SonHiz),
                new SqlParameter("@Hizlanma", ozl.Hizlanma),
                new SqlParameter("@Yili", ozl.Yili)
                };
            int sonuc = hlp.ExecuteNonQuery("INSERT INTO Ozellik values(@Tipi,@Cekis,@Motor,@Beygir,@Tork,@YTüketimi,@YTürü,@SonHiz,@Hizlanma,@Yili)", p);
            return sonuc > 0;
        }
        public DataTable ArabaTablosu()
        {
            DataTable dt = hlp.MyOgrenciTable("select * from Ozellik");
            return dt;
        }
        public bool Guncelle(DataGridView grid)
        {
            try
            {
                if (hlp.DataUpdate("spOzellikguncelle", grid) == 0)
                {
                    return false;
                }

                hlp.DataUpdate("spOzellikguncelle", grid);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*public bool OzellikGuncelle(Ozellikler grid)
        {
            try
            {
                
                if (hlp.DataUpdate("spOzellikguncelle", grid) == 0)
                {
                    return false;
                }

                hlp.DataUpdate("spOzellikguncelle", grid);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            //try
            //{
            //    SqlParameter[] p =
            //                    { new SqlParameter("@Tipi",ozl.Tipi),
            //                new SqlParameter("@Cekis", ozl.Cekis),
            //                new SqlParameter("@Motor", ozl.Motor),
            //                new SqlParameter("@Beygir", ozl.Beygir),
            //                new SqlParameter("@Tork", ozl.Tork),
            //                new SqlParameter("@YTüketimi",ozl.YTüketimi),
            //                new SqlParameter("@YTürü",ozl.YTürü),
            //                new SqlParameter("@SonHiz",ozl.SonHiz),
            //                new SqlParameter("@Hizlanma",ozl.Hizlanma),
            //                new SqlParameter("@Yili",ozl.Yili),
            //                new SqlParameter("@OzellikId",ozl.OzellikId) };

            //    int sonuc = hlp.ExecuteNonQuery("Update Ozellik set Tipi=@Tipi,Cekis=@Cekis,Motor=@Motor,Beygir=@Beygir,Tork=@Tork,YTüketimi=@YTüketimi,YTürü=@YTürü,SonHiz=@SonHiz,Hizlanma=@Hizlanma,Yili=@Yili,OzellikId=@OzellikId", p);
            //    return sonuc > 0;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }*/

    }
}
