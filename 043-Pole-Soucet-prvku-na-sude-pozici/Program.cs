using System;

namespace _043_Pole_Soucet_prvku_na_sude_pozici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poleCisel = new int[] { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186 };

            int soucet = 0;

            for (int i = 0; i < poleCisel.Length; i++)
            {
                if (i % 2 == 0)
                    soucet += poleCisel[i];
            }

            Console.WriteLine("Součet čísel na sudé pozici je {0}", soucet);
            Console.WriteLine();

            soucet = 0;

            for (int i = 0; i < poleCisel.Length; i+=2)
            {
                soucet += poleCisel[i];
            }

        }
    }
}
