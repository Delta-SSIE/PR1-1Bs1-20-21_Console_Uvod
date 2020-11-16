using System;

namespace _023_for_ukazka_nasobilka
{
    class Program
    {
        static void Main(string[] args)
        {
            //vypiš malou násobilku nějakého čísla
            //1x5 = 5
            //2x5 = 10

            int cislo = 5;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}x{cislo} = {i * cislo}");
            }
        }
    }
}
