using System;
using System.Diagnostics;

namespace _064_Fibonacci
{
    class Program
    {
        static int pocet;
        static void Main(string[] args)
        {
            Stopwatch stopky = new Stopwatch();
            //Fibonacci: 1 1 2 3 5 8 13 21
            //pocet = 0;
            //Console.WriteLine(Fib(1));
            //Console.WriteLine(pocet);
            //Console.WriteLine();

            //pocet = 0;
            //Console.WriteLine(Fib(5));
            //Console.WriteLine(pocet);
            //Console.WriteLine();

            //pocet = 0;
            ulong n = 50;

            //stopky.Start();
            //Console.WriteLine(Fib(n));
            //stopky.Stop();
            //Console.WriteLine(stopky.ElapsedTicks);
            ////Console.WriteLine(pocet);
            //Console.WriteLine();

            //pocet = 0;
            ulong[] m = new ulong[n +1];
            stopky.Restart();
            Console.WriteLine(FibM(n, m));
            //Console.WriteLine(pocet);
            stopky.Stop();
            Console.WriteLine(stopky.ElapsedTicks);
            Console.WriteLine();

            stopky.Restart();
            Console.WriteLine(FibC(n));
            //Console.WriteLine(pocet);
            stopky.Stop();
            Console.WriteLine(stopky.ElapsedTicks);
            Console.WriteLine();

            stopky.Restart();
            Console.WriteLine(FibF(n));
            //Console.WriteLine(pocet);
            stopky.Stop();
            Console.WriteLine(stopky.ElapsedTicks);
            Console.WriteLine();
        }

        static ulong Fib(ulong n)
        {
            pocet++;
            return n < 3 ? 1 : Fib(n - 1) + Fib(n - 2);
        }

        static ulong FibM(ulong n, ulong[] memory)
        {
            pocet++;

            if (memory[n] != 0)
                return memory[n];

            ulong fib = n < 3 ? 1 : FibM(n - 1, memory) + FibM(n - 2, memory);
            memory[n] = fib;
            return fib;

        }

        static ulong FibC(ulong n)
        {
            if (n < 3)
                return 1;

            ulong n1 = 1;
            ulong n2 = 1;
            for (ulong i = 0; i < n; i++)
            {
                ulong n0 = n1 + n2;
                n2 = n1;
                n1 = n0;
            }

            return n1;
        }

        static ulong FibF(ulong n)
        {
            double sqrt5 = Math.Sqrt(5);
            return (ulong) Math.Round( Math.Pow((1 + sqrt5) / 2, n) / sqrt5);
        }
    }
}
