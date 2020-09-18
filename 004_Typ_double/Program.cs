using System;

namespace _004_typ_double
{
    class Program
    {
        static void Main(string[] args)
        {
            //double cislo = 1.01;            
            double cislo = 1.01 * 1000000000000000000;
            double vetsiCislo = cislo + 1;
            double rozdil = vetsiCislo - cislo;

            Console.WriteLine("Číslo je " + cislo);
            Console.WriteLine("Větší číslo je " + vetsiCislo);
            Console.WriteLine("Rozdíl čísel je " + rozdil);

            Console.WriteLine("Zadej číslo");
            string nacteno = Console.ReadLine();
            double nacteneCislo = double.Parse(nacteno);

            Console.WriteLine("Zadal jsi: " + nacteno);

        }
    }
}
