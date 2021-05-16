using System;
using System.Collections.Generic;

namespace _088_Slovnik_se_zapisem
{
    class Program
    {

        enum Mode { Learn, Translate }

        static void Main(string[] args)
        {
            string filename = "dictionary.txt";
            Translator tran = new Translator(filename);
            Mode mode = Mode.Learn;

            Console.WriteLine("Učicí a překládací režim přepnete příkazem '-', příkaz '*' program ukončí.");

            while (true)
            {
                if (mode == Mode.Learn)
                {
                    string en = tran.GetWord("Zadejte slovo anglicky");

                    if (en == "-")
                    {
                        mode = Mode.Translate;
                        Console.WriteLine("Zapnut režim překladu");
                        continue;
                    }
                    else if (en == "*")
                    {
                        break;
                    }

                    string cs = tran.GetWord("Zadejte slovo česky");

                    tran.Dictionary[en] = cs;
                }

                else

                {
                    string en = tran.GetWord("Jaké anglické slovo chcete přeložit");

                    if (en == "-")
                    {
                        mode = Mode.Learn;
                        Console.WriteLine("Zapnut režim učení");
                        continue;
                    }
                    else if (en == "*")
                    {
                        break;
                    }

                    if (tran.Dictionary.ContainsKey(en))
                        Console.WriteLine("Česky: " + tran.Dictionary[en]);
                    else
                        Console.WriteLine("Toto slovo nemám uloženo");                    

                }
            }
            tran.WriteDictionary();
        }

    }
}

