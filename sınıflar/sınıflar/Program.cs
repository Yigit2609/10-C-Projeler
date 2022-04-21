using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sınıflar
{
    class Ucgen
    {
        public int a;
        public int b;
        public int c;
        private string sekil;
        public void alan()
        {
        }      
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen u = new Ucgen();
            u.a = 5;
            u.b = 9;
            u.c = 0;
            Console.WriteLine("Üçgenin a kenar uzunluğu: {0}", u.a);
            Console.WriteLine("Üçgenin b kenar uzunluğu: {0}", u.b);
            Console.WriteLine("Üçgenin c kenar uzunluğu: {0}", u.c);
            Console.ReadKey();
            Ucgen ucgen2 = new Ucgen();
            ucgen2.a = 6;
            ucgen2.b = 4;

        }
    }
}

