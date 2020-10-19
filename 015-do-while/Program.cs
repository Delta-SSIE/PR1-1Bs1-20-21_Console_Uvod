using System;

namespace _015_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // …
            // …
            // …
            // …

            string odpoved;
            bool poprve = true;

            do 
            {
                if (!poprve)
                    Console.WriteLine("Neplatná odpověď");

                Console.WriteLine("Ukončit? (A/N)");
                odpoved = Console.ReadLine().ToUpper();
                poprve = false;
            } 
            while (odpoved != "A" && odpoved != "N") ;

            Console.WriteLine(odpoved == "A" ? "končím" : "pokračuju");
        }
    }
}
