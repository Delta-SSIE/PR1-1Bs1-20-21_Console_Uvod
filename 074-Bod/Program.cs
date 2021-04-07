using System;

namespace _074_Bod
{
    class Program
    {
        static void Main(string[] args)
        {
            Bod bodA = new Bod(1, 1);
            //Bod bodB = bodA;
            Bod bodB = new Bod(1, 1);
            Bod bodC = new Bod(5, 4);


            if (bodA.Equals(bodB))
                Console.WriteLine($"Body {bodA} a {bodB} jsou shodné");
            else
                Console.WriteLine("Body A a B nejsou shodné");

            if (bodA.Equals(bodC))
                Console.WriteLine("Body A a C jsou shodné");
            else
                Console.WriteLine("Body A a C nejsou shodné");

            Console.WriteLine($"Vzdálenost bodů {bodA} a {bodB} je {bodA.VzdalenostOd(bodB)}");
            Console.WriteLine($"Vzdálenost bodů {bodA} a {bodC} je {bodA.VzdalenostOd(bodC)}");

            Console.WriteLine($"Bod A: {bodA}");
        }
    }
}
