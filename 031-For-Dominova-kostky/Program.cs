using System;

namespace _031_For_Dominove_kostky
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte všechny kombinace, které se mohou vyskytnout na dominových kamenech
            //Tedy:
            //0-0
            //0-1
            //0-2
            //…
            //0-6
            //1-1
            //1-2
            //…
            //1-6
            //2-2
            //…

            for (int i = 0; i < 7; i++) //první číslo nabývá hodnoty od 0 do 6
            {
                for (int j = i; j < 7; j++) //druhé číslo začíná na hodnotě prvního a stoupá až do 6
                {
                    Console.WriteLine($"{i}|{j}"); //výpis obou hodnot
                }
                Console.WriteLine();
            }
        }
    }
}
