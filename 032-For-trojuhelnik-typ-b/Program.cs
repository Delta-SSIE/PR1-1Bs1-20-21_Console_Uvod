using System;

namespace _032_For_trojuhelnik_typ_b
{
    class Program
    {
        static void Main(string[] args)
        {
            //#
            //##
            //###
            //####
            //#####
            //######  

            int velikost = 4;

            for (int radek = 0; radek < velikost; radek++)
            {
                for (int sloupec = 0; sloupec <= radek; sloupec++)
                {
                    Console.Write("#");
                    Console.Write("█");
                }
                Console.WriteLine();
            }
        }
    }
}
