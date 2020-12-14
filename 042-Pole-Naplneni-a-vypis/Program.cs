using System;

namespace _042_Pole_Naplneni_a_vypis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik čísel si mám zapamatovat: ");
            int pocet = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("Zadej {0} celých čísel: ", pocet);
            int[] cisla = new int[pocet];

            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej {0}. číslo: ", i + 1);
                cisla[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < cisla.Length; i++)
            {
                //int cislo = cisla[i];
                //if (cislo > 2)
                //    Console.WriteLine(cislo);
                if (cisla[i] > 2)
                    Console.WriteLine(cisla[i]);
            }
        }
    }
}
