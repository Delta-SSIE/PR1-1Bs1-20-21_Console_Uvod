using System;

namespace _034_For_Sachovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který vypíše všechna pole na šachovnici

            //Poté jej změňte tak, aby byla černá a bílá pole barevně odlišena.
            //K tomu využijete vlastnosti Console.ForegroundColor a 
            //Console.BackgroundColor

            //Až bude hotovo, přidejte ještě načtení pozice z klávesnice a při 
            //výpisu tuto pozici obarvěte jinak.

            //…
            //A2 B2 C2 …
            //A1 B1 C1 …

            Console.Write("Které pole chceš zvýraznit: ");
            string odpoved = Console.ReadLine().ToUpper();
            int zvyraznenyRadek = odpoved[1] - '0';
            char zvyraznenySloupec = odpoved[0];

            for (int radek = 8; radek > 0; radek--)
            {
                bool pristiPoleBile = radek % 2 == 0;

                for (char sloupec = 'A'; sloupec < 'I'; sloupec++)
                {

                    if (pristiPoleBile)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkYellow; 
                    }

                    if (sloupec == zvyraznenySloupec && radek == zvyraznenyRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    

                    Console.Write(sloupec);
                    Console.Write(radek);
                    Console.Write(" ");

                    pristiPoleBile = !pristiPoleBile;
                }
                Console.WriteLine();
            }
        }
    }
}
