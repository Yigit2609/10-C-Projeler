using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hesap_Makinesi
{
    class Hesap
    {
        public double sayi1 { get; set; }
        public double sayi2 { get; set; }
        public char sembol { get; set; }
        public bool EsittireBasildimi { get; set; }
        //Methodlar****************************
        public Hesap() {
            EsittireBasildimi = false;
        }
        //*****************************************
        public double SayilariTopla() {
            return sayi1 + sayi2;
        }
        public double SayilariCikar() {
            return sayi1 - sayi2;
        }
        public double SayilariCarp() {
            return sayi1 * sayi2;
        }
        public double SayilariBol() {
            return sayi1 / sayi2;
        }
        public string HesapYap() {
            string sonuc = "";
            switch (sembol)
            {
                case '+':
                    sonuc = SayilariTopla().ToString();
                    break;
                case '-':
                    sonuc = SayilariCikar().ToString();
                    break;
                case '*':
                    sonuc = SayilariCarp().ToString();
                    break;
                case '/':
                    sonuc = SayilariBol().ToString();
                    break;
                
                default:
                    break;
            }

            return sonuc;
        }



    }

}
