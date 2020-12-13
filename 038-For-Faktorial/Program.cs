using System;

namespace _038_For_Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = 6;
            ulong faktorial = 1;

            for (ulong i = n; i > 0; i--)
            {
                faktorial *= i;
            }

            Console.WriteLine($"{n}! = {faktorial}");
        }
    }
}
