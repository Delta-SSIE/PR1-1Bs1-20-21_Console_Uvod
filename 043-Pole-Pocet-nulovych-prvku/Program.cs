using System;

namespace _043_Pole_Pocet_nulovych_prvku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 124, 56, 0, 0, 0, 65, 584, 12, 0, 6 };

            //připravím počítadlo
            int pocetNul = 0;

            //projdu pole
            for (int i = 0; i < pole.Length; i++)
            {
                //když najdu nulu, připočítám si ji
                if (pole[i] == 0)
                {
                    pocetNul++;
                }
            }

            //výpis
            Console.WriteLine("V poli je {0} nulových prvků.", pocetNul);
        }
    }
}
