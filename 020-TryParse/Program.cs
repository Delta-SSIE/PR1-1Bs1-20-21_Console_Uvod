using System;

namespace _020_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo: ");

            double cislo;
            while (!double.TryParse(Console.ReadLine(), out cislo)) 
            {
                Console.WriteLine("Má to být číslo.");
            }

            Console.WriteLine("Zadal jsi {0}", cislo);

            
        }
    }
}
