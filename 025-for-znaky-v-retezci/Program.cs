using System;

namespace _025_for_znaky_v_retezci
{
    class Program
    {
        static void Main(string[] args)
        {
            string veta = "Byl jednou jeden král";          

            for (int i = 0; i < veta.Length; i++)
            {

                //Console.WriteLine(veta[i]);

                char znak = veta[i];
                Console.Write(znak);
                Console.Write(" ");
                Console.Write((int) znak);
                Console.WriteLine();
            }            
        }
    }
}
