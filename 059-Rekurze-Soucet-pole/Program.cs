using System;

namespace _059_Rekurze_Soucet_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { 7, 12, 1, -1, 0, 4, 5 };
            Console.WriteLine($"Součet je {SectiPole(cisla)}");
        }

        static int SectiPole(int[] pole, int start = 0)
        {
            if (start == pole.Length - 1)
                return pole[start];
            return SectiPole(pole, start + 1) + pole[start];
        }
    }
}
