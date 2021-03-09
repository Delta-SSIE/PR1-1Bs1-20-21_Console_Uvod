using System;

namespace _060_Rekurze_Vsechna_suda
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] cisla = new int[] { 7, 12, 1, 1, 0, 4, 5 };
            //int[] cisla = new int[] { 4, 6, 8};
            //int[] cisla = new int[] { };
            int[] cisla = new int[100000];            
            Console.WriteLine(JsouVsechnaSuda(cisla) ? "Všechna jsou sudá" : "Existuje nějaké liché");
        }

        static bool JsouVsechnaSuda(int[] pole, int start = 0)
        {
            if (start >= pole.Length)
                return true;

            return (pole[start] % 2 != 0) ? false : JsouVsechnaSuda(pole, start + 1);
            //// všechna jsou sudá, když toto je sudé a všechna další také
            //if (pole[start] % 2 != 0)
            //    return false;

            ////teď už vím, že toto pole je sudé
            //return JsouVsechnaSuda(pole, start + 1);
        }

    }
}
