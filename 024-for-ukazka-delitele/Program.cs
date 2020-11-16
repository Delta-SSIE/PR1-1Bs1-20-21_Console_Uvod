using System;

namespace _024_for_ukazka_delitele
{
    class Program
    {
        static void Main(string[] args)
        {
            //vypište všechny dělitele zadaného čísla
            int cislo = 144;

            for (int i = cislo; i > 0; i--)
            {
                if (cislo % i == 0)
                    Console.WriteLine($"{cislo} = {i} * {cislo / i}");
            }
        }
    }
}
