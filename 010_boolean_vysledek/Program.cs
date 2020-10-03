using System;

namespace _010_boolean_vysledek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool delitelno3;

            int cislo = 15;

            //if (cislo % 3 == 0)
            //{
            //    delitelno3 = true;
            //}
            //else
            //{
            //    delitelno3 = false;
            //}

            delitelno3 = cislo % 3 == 0;

            if (delitelno3)
            {
                Console.WriteLine("Jde to dělit");
            }
            else
            { 
                Console.WriteLine("Nejde to dělit");
            }
        }
    }
}
