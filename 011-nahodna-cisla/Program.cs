using System;

namespace _011_nahodna_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int cislo = generator.Next(1, 11);
            Console.WriteLine(cislo);

            int stav = generator.Next(0, 2);           
            if (stav == 0)
                Console.WriteLine("Panna");
            else
                Console.WriteLine("Vorel");
        }
    }
}
