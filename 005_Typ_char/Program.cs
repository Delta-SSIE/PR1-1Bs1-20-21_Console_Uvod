using System;

namespace typ_char
{
    class Program
    {
        static void Main(string[] args)
        {
            char pismeno = 'A';
            //char pismeno2 = (char)(pismeno + 1);
            char pismeno2 = (char)(pismeno + 'b');
            Console.WriteLine("Písmenko je: " + pismeno);
            Console.WriteLine("Další písmenko je: " + pismeno2);
        }
    }
}
