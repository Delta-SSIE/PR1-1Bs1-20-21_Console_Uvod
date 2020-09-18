using System;

namespace _002_Jak_se_jmenujes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jak se jmenuješ?"); // vypíšu výzvu

            string name; // oznámím počítači, že budu používat proměnnou name
                         // a bude to řetězec (kus textu) - string

            name = Console.ReadLine(); // načtení z klávesnice a uložení do name

            Console.WriteLine("Hello " + name + "!"); // slepení řetězců operátorem +

            Console.ReadKey();
        }
    }
}
