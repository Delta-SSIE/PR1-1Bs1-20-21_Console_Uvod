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


        }
    }
}
