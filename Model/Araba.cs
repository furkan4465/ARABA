using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Araba
    {
        public int Araba_id { get; set; }
        public string Araba_Kategori { get; set; }
        public int Ust_Kategori_id { get; set; }
    }
}
