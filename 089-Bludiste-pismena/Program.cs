using System;

namespace _089_Bludiste_pismena
{
    class Program
    {
        static void Main(string[] args)
        {
            Bludiste b = new Bludiste();
            b.Nacti("bludiste-1.txt");
            char[] cesta = b.Projdi();
            Console.WriteLine(String.Join("-", cesta));

        }
    }
}
