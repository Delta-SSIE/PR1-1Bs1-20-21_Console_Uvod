using System;

namespace _009_typ_boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jeOsklive = true;
            bool chciJitVen = false;

            if ( !(jeOsklive && !chciJitVen) )
            {
                Console.WriteLine("Jde se ven");
            } 
            else
            {
                Console.WriteLine("Zůstaneme doma");
            }

        }
    }
}
