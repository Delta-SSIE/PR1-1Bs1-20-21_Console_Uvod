using System;

namespace _071_Kruznice_konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(4);
                //k.NastavPolomer(4);
                //Console.WriteLine(k._polomer);
                Console.WriteLine($"Obvod kružnice o poloměru {k.VratPolomer()} je {k.Obvod()}");

                Kruznice l = new Kruznice();
                l.NastavPolomer(10);
                //Console.WriteLine(k._polomer);
                Console.WriteLine($"Obvod kružnice o poloměru {l.VratPolomer()} je {l.Obvod()}");

            }
            catch (Exception)
            {
                Console.WriteLine("Došlo k neočekávané chybě programu.");
            }
        }
    }
}
