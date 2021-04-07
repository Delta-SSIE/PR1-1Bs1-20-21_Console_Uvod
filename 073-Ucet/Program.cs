using System;

namespace _073_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet provozni = new Ucet();
            provozni.Uloz(500);
            Console.WriteLine("Zůstatek na účtu je {0}", provozni.Zustatek);

            double vKapse = 100;

            if (provozni.Vyber(200))
            {
                Console.WriteLine("Vybírám 200");
                vKapse += 200;
            }
            else
                Console.WriteLine("Nemám na kino");

            Console.WriteLine("Ted mám {0}", provozni.Zustatek);
            Console.WriteLine("Uběhne rok");

            provozni.Urokuj(1.1);
            Console.WriteLine("Uběhl rok, na účtu je {0}", provozni.Zustatek);

            Ucet sporici = new Ucet();
            double start = 300;
            sporici.Uloz(start);
            double cil = 500;
            int obdobi = 0;
            double urokovaMira = 11;

            while (sporici.Zustatek < cil)
            {
                obdobi++;
                sporici.Urokuj(urokovaMira);
            }

            Console.WriteLine($"Spoření z {start} na {cil} při úrokové míře {urokovaMira} p.a. trvá {obdobi} let");
        }
    }
}
