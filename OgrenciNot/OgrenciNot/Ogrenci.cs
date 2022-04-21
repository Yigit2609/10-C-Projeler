using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciNot
{
    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public double Sinav1 { get; set; }
        public double Sinav2 { get; set; }
        public double Performans { get; set; }

        public double OrtalamaHesapla()
        {
            double ort = (Sinav1 + Sinav2 + Performans) / 3;
            return ort;
        }

        public override string ToString()
        {
            return No + "-" + Ad + " " + Soyad;
        }
    }
}
