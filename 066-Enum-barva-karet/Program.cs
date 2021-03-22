using System;

namespace _066_Enum_barva_karet
{
    class Program
    {
        enum Barva { Srdce, Kary, Piky, Krize, Trefy = Krize };

        static void Main(string[] args)
        {
            Barva moje = Barva.Krize;
            Barva tvoje = Barva.Trefy;
            if (moje == tvoje)
                Console.WriteLine("Máme stejnou barvu");
            else
                Console.WriteLine("Každý máme jinou barvu");
        }
    }
}
