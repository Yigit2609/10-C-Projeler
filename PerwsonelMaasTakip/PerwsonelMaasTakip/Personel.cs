using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerwsonelMaasTakip
{
    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public int Yetki { get; set; }
        public int IzinliOlduguGun { get; set; }

        public double MaasHesapla()
        {
            int gun = 30 - IzinliOlduguGun;

            if (Yetki == 0)
                return gun * 300;
            else if (Yetki == 1)
                return gun * 200;
            else return gun * 180;
        }

        public override string ToString()
        {
            if(Yetki == 0)
                return Ad + " " + Soyad+" (Müdür)";
            else if(Yetki == 1)
                return Ad + " " + Soyad + " (İşçi)";
            else return Ad + " " + Soyad + " (Ofis Personeli)";
        }
    }
}
