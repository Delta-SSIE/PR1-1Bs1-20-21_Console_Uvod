using System;

namespace _017_while_opak_prochazeni_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int soucin = 1;

            while (i <= 10)
            {
                soucin *= i;
                i++;
            }

            Console.WriteLine("Součin je {0}.", soucin);
        }
    }
}
