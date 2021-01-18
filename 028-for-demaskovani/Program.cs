using System;
using System.IO;
using System.Text;

namespace _028_for_demaskovani
{
    class Program
    {
        static void Main(string[] args)
        {
            string cestaVstup = @"vstup.txt";

            if (!File.Exists(cestaVstup))
            {
                Console.WriteLine("File not found");
                return;
            }

            string maskovano = File.ReadAllText(cestaVstup);

            // sem prijde vas kod

            maskovano = maskovano.ToUpper();


            int max = 10;

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string demaskovano = "";
                    Console.WriteLine($"{i}:{j}");

                    for (int pozice = j; pozice < maskovano.Length; pozice += i)
                    {
                        demaskovano += maskovano[pozice];
                    }

                    Console.WriteLine(demaskovano);
                    Console.WriteLine();
                }
            }
        }
    }
}
