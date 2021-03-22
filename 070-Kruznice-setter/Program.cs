using System;

namespace _070_Kruznice_setter
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Kruznice k = new Kruznice();
                k.NastavPolomer(-4);
                //Console.WriteLine(k._polomer);
                Console.WriteLine($"Obvod kružnice o poloměru {k.VratPolomer()} je {k.Obvod()}");

            }
            catch (Exception)
            {
                Console.WriteLine("Došlo k neočekávané chybě programu.");
            }
        }
    }
}
