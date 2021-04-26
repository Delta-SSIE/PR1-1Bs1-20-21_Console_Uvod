using System;
using System.Collections.Generic;

namespace _079_List_Erathostenovo_sito
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes1 = PrimesUpTo(30000);
            Console.WriteLine(String.Join(", ", primes1));
        }

        static int[] PrimesUpTo(int n)
        {
            bool[] numbers = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
                numbers[i] = true;

            numbers[0] = false;
            numbers[1] = false;

            int max = (int)Math.Sqrt(n);
            List<int> primes = new List<int>();

            for (int test = 2; test <= max; test++)
            {
                if (!numbers[test])
                    continue;

                primes.Add(test);
                for (int cancel = test * 2; cancel < n + 1; cancel += test)
                {
                    numbers[cancel] = false;
                }
            }

            return primes.ToArray();
        }
    }
}
