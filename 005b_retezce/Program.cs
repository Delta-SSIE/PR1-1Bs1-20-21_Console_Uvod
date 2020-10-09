using System;

namespace _005b_retezce
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Franta";
            int pocet = 4;

            Console.WriteLine(jmeno + " má " + pocet + " kočky.");
            Console.WriteLine("{0} má {1} kočky.", jmeno, pocet);
            Console.WriteLine($"{jmeno} má {pocet} kočky.");
        }
    }
}
