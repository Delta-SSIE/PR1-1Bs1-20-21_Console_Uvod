using System;

namespace _021_for_ukazka
{
    class Program
    {
        static void Main(string[] args)
        {

            int nasobek = 1;

            for ( int i = 0; i < 11; i++ )
            {
                Console.WriteLine("2^{0} = {1}", i, nasobek);
                nasobek *= 2;
            }

            Console.WriteLine("Konec");
        }
    }
}
