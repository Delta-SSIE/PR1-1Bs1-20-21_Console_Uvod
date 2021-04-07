using System;

namespace _072_Kruznice_Vlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice(4);
            //k.Polomer = 4;
            Console.WriteLine($"Kruznice o poloměru {k.Polomer} má obsah {k.Obsah}");

            Kruznice l = new Kruznice(-1);
            //l.Polomer = -1;
        }
    }
}
