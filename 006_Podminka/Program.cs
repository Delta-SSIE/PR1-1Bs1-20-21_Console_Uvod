using System;

namespace _006_Podminka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik je ti let: ");
            string nacteno = Console.ReadLine();
            int vek = int.Parse(nacteno);

            if (vek < 21)
            {
                Console.WriteLine("Kup si radši lízátko");
                Console.WriteLine("A jdi radši do kina");
            }
            else
            {
                Console.WriteLine("Můžeš kandidovat");
            }

            if (vek == 21)
            {
                Console.WriteLine("…ale je to natěsno");
            }

        }
    }
}
