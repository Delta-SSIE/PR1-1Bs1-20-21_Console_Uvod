using System;

namespace _045_Split_a_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, 5, 10, 17, 26 };
            //string spojeno = string.Join("|", cisla);
            string text = "Eva, Marie, Hana, Kateřina";

            string[] jmena = text.Split(", ");

            for (int i = 0; i < jmena.Length; i++)
            {
                Console.WriteLine(jmena[i]);
            }

        }
    }
}
