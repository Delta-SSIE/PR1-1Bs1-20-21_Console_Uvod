using System;

namespace _040_Vanocni_vyzva_reseni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sifraPole = new string[]
            {
                "ABCDEFGIJKMOSTUVWXY",
                "AGIJKQSY",
                "ACDEGIKLNPQSUVWY",
                "ACDEGIJLOSUVWY",
                "ACDEGNOPQSUVWY",
                "AGILMNOSY",
                "ABCDEFGIKMOQSTUVWXY",
                "JMO",
                "ABEFGLNOQTVWXY",
                "ACDFHJKMPQTUVX",
                "ABCDGLMNOPRTV",
                "BCEFHKLNRTUW",
                "BCFGKMNPRSTWY",
                "BCENOPQRTVW",
                "ABDFGJKPRTU",
                "ABHIMOQRWX",
                "CEFGJLNOPQRSTUVWY",
                "IJMQUVX",
                "ABCDEFGLMNOQSUW",
                "AGILNQUY",
                "ACDEGIJMNQRSTUY",
                "ACDEGJNORSTUVXY",
                "ACDEGJQRSTUVWX",
                "AGIJKMOPSTVX",
                "ABCDEFGIJKLNOPRXY",
            };

            //princip řešení mi pomůže najít to, že všechny řetězce jsou seřazeny podle abecedy a některá písmena chybí.
            //pracuje se s 25 písmeny anglické abecedy (zjevně chybí Z) a také je 25 řádků
            // =>  to odpovídá nějaké mřížce. Zkusíme vybarvit všechna "obsazená" políčka

            // nastavím černé na bílém - že se to bude hodit ale zjistím až pro prvním prolomení šifry
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear(); //toto mi vymaže konzoli - vše bude v "nových" barvách
            Console.WriteLine(); //prázdný řádek nahoře, jen pro vzhled

            for (int i = 0; i < sifraPole.Length; i++) //projdu všechny řádky
            {
                string radek = sifraPole[i]; //uložím si řádek do dočasné proměnné
                int pozice = 0; //pamatuju si, na které pozici v něm jsem

                Console.Write("  "); //prázdný znak vlevo, opět jen pro vzhled

                for (char znak = 'A'; znak < 'Z'; znak++) //projdu všechny znaky abecedy do Y (poslední v šifře)
                {
                    if (radek[pozice] == znak) //když je pozice v mé šifře obsazená
                    {
                        Console.Write("██"); //"vybarvím" políčko
                        pozice++; // posunu si ukazatel dalšího znaku v prohledávaném řetězci
                        if (pozice >= radek.Length) 
                        {
                            break; //pokud jsem už došel na jeho konec, nemusím se dál snažit a jdu na další řádek
                        }
                    }
                    else //jinak - když není obsazená pozice
                    {
                        Console.Write("  "); //nechám prázdné
                    }
                }
                Console.WriteLine(); //za každým řádkem ve zdrojové šifře také odřádkuju
            }
        }
    }
}
