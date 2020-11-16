using System;

namespace _019_While_Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej kladná čísla, já zjistím, které z nich bylo nejmenší.");
            Console.WriteLine("Zadávání ukončíš příkazem \"konec\"");

            double minimum = double.MaxValue;
            int pocet = 0;

            while (true)
            {
                Console.Write("Další číslo: ");
                string nacteno = Console.ReadLine();

                if (nacteno == "konec")
                    break;

                double cislo = double.Parse(nacteno);
                

                pocet++;
                if (cislo < minimum)
                    minimum = cislo;
            }

            if (pocet > 0)
                Console.WriteLine("Nejmenší číslo bylo {0}.", minimum);
            else
                Console.WriteLine("Nebylo žádné číslo zadáno.");
        }

        static void MainOld(string[] args)
        {
            Console.WriteLine("Zadávej kladná čísla, já zjistím, které z nich bylo nejmenší.");
            Console.WriteLine("Zadávání ukončíš zadáním záporného čísla nebo nuly");

            double minimum = double.MaxValue;
            int pocet = 0;

            while (true)
            {
                Console.Write("další číslo: ");
                double cislo = double.Parse(Console.ReadLine());

                if (cislo <= 0)
                    break;

                pocet++;
                if (cislo < minimum)
                    minimum = cislo;
            }

            if (pocet > 0)
                Console.WriteLine("Nejmenší číslo bylo {0}.", minimum);
            else
                Console.WriteLine("Nebylo žádné číslo zadáno.");
        }

    }
}
