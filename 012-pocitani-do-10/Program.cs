using System;

namespace _012_pocitani_do_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            //while ( i <= 100 )
            while ( i >= 0 )            {
            Console.WriteLine(i);
                //i += 1;
                //i += 5;
                i -= 1;
            }

            Console.WriteLine("Konec");
        }
    }
}
