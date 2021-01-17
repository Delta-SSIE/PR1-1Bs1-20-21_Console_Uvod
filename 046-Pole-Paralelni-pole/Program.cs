using System;

namespace _046_Pole_Paralelni_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] platy =
            {
                26800,
                13200,
                33000,
                65000,
            };

            string[] jmena =
            {
                "Novotný",
                "Novák",
                "Procházka",
                "Černý"
            };

            for (int i = 0; i < platy.Length; i++)
            {
                Console.WriteLine($"Pan {jmena[i]} bere měsíčně {platy[i]}.");
            }

            string hledany = "Procházka";
            for (int i = 0; i < platy.Length; i++)
            {
                if (jmena[i] == hledany)
                    Console.WriteLine($"Plat je {platy[i]}.");
            }


        }
    }
}
