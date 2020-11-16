using System;

namespace _026_for_ukazky_zasifruj
{
    class Program
    {
        static void Main(string[] args)
        {
            string veta = "Byl jednou jeden král";
            Random rnd = new Random();
            string zamaskovano = "";

            for (int i = 0; i < veta.Length; i++)
            {
                zamaskovano += veta[i];
                for (int j = 0; j < 4; j++)
                {
                    zamaskovano +=  (char)rnd.Next(97, 123);
                }                
            }

            Console.WriteLine(zamaskovano);

        }
    }
}
