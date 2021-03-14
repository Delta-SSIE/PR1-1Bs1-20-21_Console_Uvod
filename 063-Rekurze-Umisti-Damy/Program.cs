using System;

namespace _063_Rekurze_Umisti_Damy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] stav = new int[] { 3, 0, 2, 1 };
            //Zobraz(stav);
            int pocet = UmistiDamy(new int[13], 0, 0);
            Console.WriteLine(pocet);
        }

        static int UmistiDamy(int[] stav, int radek, int pocet)
        {
            for (int sloupec = 0; sloupec < stav.Length; sloupec++)
            {
                if (!LzeUmistit(stav, radek, sloupec))
                    continue;

                //v dalším kódu vím, že umístit lze

                stav[radek] = sloupec;

                if (radek == stav.Length - 1)
                {
                    pocet++;
                    //Zobraz(stav, pocet);
                }
                else
                {
                    pocet = UmistiDamy(stav, radek + 1, pocet);
                }
            }
            return pocet;
        }

        static bool LzeUmistit(int[] stav, int radek, int sloupec)
        {
            for (int testRadek = 0; testRadek < radek; testRadek++)
            {
                if (sloupec == stav[testRadek])
                    return false;

                if (radek - testRadek ==  Math.Abs(sloupec - stav[testRadek]))
                    return false;
            }
            return true;
        }

        static void Zobraz(int[] stav, int pocet)
        {
            Console.WriteLine("".PadRight(2 * stav.Length + 1, '-'));
            Console.WriteLine($" Pozice č. {pocet}");
            Console.WriteLine("".PadRight(2 * stav.Length + 1, '-'));
            Console.WriteLine();

            for (int radek = 0; radek < stav.Length; radek++)
            {
                for (int sloupec = 0; sloupec < stav[radek]; sloupec++)
                {
                    Console.Write(" -");
                }
                Console.Write(" Q");
                for (int sloupec = stav[radek] + 1; sloupec < stav.Length; sloupec++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
