using System;

namespace _048_metody_syntaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pozdrav("Karel");
            //Pozdrav("Ludvík");
            //string koho = "Věra";
            //Pozdrav(koho);

            string[] lide = { "Eva", "František", "Miroslav" };
            for (int i = 0; i < lide.Length; i++)
            {
                Pozdrav(lide[i]);
            }

            string jmeno = "Jiří";
            Pozdrav("Karel");
        }
        static void Pozdrav(string jmeno)
        {
            Console.WriteLine($"Ať žije {jmeno}!");
        }
    }
}
