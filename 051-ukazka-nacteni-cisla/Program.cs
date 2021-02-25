using System;

namespace _051_ukazka_nacteni_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zeptejte se uživatele na počet ukládaných celých čísel
            //Console.WriteLine("Jak velké bude pole?");
            int pocet = NactiInt("Jak velké bude pole: ");
            //Potom vytvořte odpovídající pole
            int[] cisla = new int[pocet];

            Console.WriteLine("Nyní budeme načítat prvky.");
            //Pak čísla postupně z klávesnice načítejte
            for (int i = 0; i < pocet; i++)
            {
                cisla[i] = NactiInt();
            }
            //Na konci pole vypište
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", cisla));
        }
        static int NactiInt(string vyzva = "Zadej celé číslo: ")
        {
            Console.Write(vyzva);
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.Write("To není celé číslo, zadej znovu: ");
            }
            return cislo;
        }
    }
}
