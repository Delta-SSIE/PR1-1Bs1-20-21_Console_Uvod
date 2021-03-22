using System;

namespace _069_OOP_uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice();

            Console.WriteLine(k.Polomer);
            Console.WriteLine($"Obvod kružnice o poloměru {k.Polomer} je {k.Obvod()}");
            k.Polomer = 10;

            Kruznice l = new Kruznice();
            l.Polomer = 5;
            Console.WriteLine($"Obvod kružnice o poloměru {k.Polomer} je {k.Obvod()}");

            Console.WriteLine($"Obvod kružnice o poloměru {l.Polomer} je {l.Obvod()}");

            
        }
    }
}
