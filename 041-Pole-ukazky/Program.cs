using System;

namespace _041_Pole_ukazky
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] domy;
            domy = new string[5];
            //string[] domy = new string[] { "Poláčkovi", "Novákovi", "Novotný" };

            //v relativně nových verzích C# je možné pole inicializovat i bez new napravo od rovnítka
            string[] lide = { "Josef", "Eva", "Marie" };

            //Console.WriteLine(domy[0]);
            //domy[2] = "Zelenkovi";
            //Console.WriteLine(domy[2]);


            //Console.WriteLine(domy.Length);

            //for (int i = 0; i < domy.Length; i++)
            for (int i = domy.Length - 1; i >= 0; i--)
                {
                    //Console.WriteLine(domy[i]);

                    //string dum = domy[i];
                    //Console.WriteLine($"V naší ulici bydlí {dum}.");

                    Console.WriteLine($"V naší ulici bydlí {domy[i]}, hodnota je uložena na indexu {i}.");
            }
        }
    }
}
