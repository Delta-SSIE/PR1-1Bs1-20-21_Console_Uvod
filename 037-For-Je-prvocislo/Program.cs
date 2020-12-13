using System;

namespace _037_For_Je_prvocislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = 51;
            bool jePrvocislo = true;

            for (int delitel = 2; delitel < Math.Sqrt(cislo); delitel++)
            {
                if (cislo % delitel == 0)
                {
                    //lze delit
                    jePrvocislo = false;
                    Console.WriteLine("Dělitel je " + delitel);
                    break;
                }
            }

            if (jePrvocislo)
            {
                Console.WriteLine($"{cislo} je prvočíslo");
            }
            else
            {
                Console.WriteLine($"{cislo} není prvočíslo");
            }
        }
    }
}
