using System;

namespace _058_Rekurze_Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cislo = 30;
            Console.WriteLine($"Faktoriál čísla {cislo} je {Fac(cislo)}.");
        }

        static ulong Fac(ulong n)
        {
            return (n < 2) ? 1 : n * Fac(n - 1);
        }
    }
}
