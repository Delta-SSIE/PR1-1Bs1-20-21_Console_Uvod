using System;

namespace _052_ukazka_Jsou_vsechna_licha
{
    class Program
    {
        static void Main(string[] args)
        {
            //napište metodu, která bude odpovídat, zda jsou všechna 
            //čísla v předaném poli lichá
            int[] cisla = { 1, 3, 5, 7 };
            int[] cisla2 = { 1, 3, 5, 8 };

            Console.WriteLine($"Pole {{{String.Join(", ", cisla2)}}} {(JsouVsechnaLicha(cisla2) ? "obsahuje" : "neobsahuje")} pouze lichá čísla.");

            Console.WriteLine(
                "Pole {{{0}}} {1} pouze lichá čísla.",
                String.Join(", ", cisla2),
                JsouVsechnaLicha(cisla2) ? "obsahuje" : "neobsahuje"
            );

        }

        static bool JsouVsechnaLicha(int[] cisla)
        {
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 != 1) //není liché
                    return false;
            }
            return true;
        }
    }
}
