using System;

namespace _004_typ_double
{
    class Program
    {
        static void Main(string[] args)
        {
            //double cislo = 1.01;            
            double cislo = 1.01 * 1000000000000000000; // vyrobím veliké číslo
            double vetsiCislo = cislo + 1; // zvětším o jedna
            double rozdil = vetsiCislo - cislo; // obě od sebe odečtu - rozdíl by měl být jedna

            Console.WriteLine("Číslo je " + cislo);
            Console.WriteLine("Větší číslo je " + vetsiCislo); 
            Console.WriteLine("Rozdíl čísel je " + rozdil); // Rozdíl ale není jedna. 
                                                            // Je nula - protože číslo nemá v paměti dost velikou přesnost

            Console.WriteLine("Zadej číslo");
            string nacteno = Console.ReadLine();
            double nacteneCislo = double.Parse(nacteno); // Parsování funguje stejně jako u integerů (celých čísel)

            Console.WriteLine("Zadal jsi: " + nacteneCislo);

        }
    }
}
