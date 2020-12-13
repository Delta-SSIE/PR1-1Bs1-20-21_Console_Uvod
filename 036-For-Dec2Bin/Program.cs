using System;

namespace _036_For_Dec2Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = 254;
            string binCislo = "";

            while (cislo > 0)
            {
                int zbytek = cislo % 2;
                binCislo = zbytek + binCislo;

                cislo /= 2;
            }

            Console.WriteLine(binCislo);
        }
    }
}
