using System;

namespace _049_Metody_navratova_hodnota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Zvys(3));
            //Console.WriteLine(Zvys(-35));

            //int vyssi = Zvys(5);

            //Console.WriteLine(NejblizsiSude(3));
            //Console.WriteLine(NejblizsiSude(4));

            Console.WriteLine(Secti(1,3,5));
        }

        static int Zvys(int cislo)
        {
            int vysledek = cislo + 1;
            return vysledek;
        }

        static int NejblizsiSude(int cislo)
        {
            if (cislo % 2 == 0)
            {
                return cislo;
            }
            else
            {
                return cislo + 1;
            }
        }

        static double Secti(double cislo1, double cislo2, double cislo3)
        {
            double vysledek = cislo1 + cislo2 + cislo3;
            return vysledek;
        }
    }
}
