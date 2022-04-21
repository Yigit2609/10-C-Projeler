using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjeTakip
{
    class Ogrenci
    {
        public int No { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }
        public int Ders { get; set; }
        public string Konu { get; set; }
        public double Not { get; set; }

        public override string ToString()
        {
            if(Ders == 0) 
                return No + "-" + Ad + " " + Soyad + " (Matematik)";
            else if (Ders == 1)
                return No + "-" + Ad + " " + Soyad + " (Fizik)";
            else if (Ders == 2)
                return No + "-" + Ad + " " + Soyad + " (İngilizce)";
            else if (Ders == 3)
                return No + "-" + Ad + " " + Soyad + " (Edebiyat)";
            else if (Ders == 4)
                return No + "-" + Ad + " " + Soyad + " (Bilişim)";

            return "-";
        }
    }
}
