using System;

namespace _050_ukazka_JeKladne
{
    class Program
    {
        static void Main(string[] args)
        {
            //double cislo = -3;
            //Console.WriteLine(cislo + (JeKladne(cislo) ? " je " : " není ") + "kladné");

            double[] cisla = { -4.32, 0, 2.7, 6.4, -1, 1.05 };

            for (int i = 0; i < cisla.Length; i++)
            {
                if (JeKladne(cisla[i]))
                {
                    Console.WriteLine(cisla[i]);
                }
            }
        }

        static bool JeKladne(double cislo)
        {
            return cislo > 0;
            //if (cislo > 0)
            //    return true;
            //else
            //    return false;
        }

    }
}
