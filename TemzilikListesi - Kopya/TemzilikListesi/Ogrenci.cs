using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemzilikListesi
{
    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return No + "-" + Ad + " " + Soyad;
        }
    }
}
