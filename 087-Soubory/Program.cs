using System;
using System.IO;

namespace _087_Soubory
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filename = @"d:\Temp\PR1\text3-utf.txt";

            //čtení celého najednou
            //try
            //{
            //    string text = System.IO.File.ReadAllText(filename);
            //    Console.WriteLine(text);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Chyba čtení souboru");
            //}

            //string[] lines = File.ReadAllLines(filename);

            ////foreach (string line in lines)
            ////{
            ////    Console.WriteLine(line);
            ////}

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    Console.WriteLine($"{i}:\t{lines[i]}");
            //}

            //string line;
            //int counter = 0;
            //using (StreamReader file = new StreamReader(filename))
            //{ 

            //    while ((line = file.ReadLine()) != null)
            //    {
            //        counter++;
            //        Console.WriteLine($"{counter}:\t{line}");
            //    }
            //}

            //čtení souboru, který je součástí projektu
            //string filename = @".\text3-utf.txt";
            ////čtení celého najednou
            //try
            //{
            //    string text = System.IO.File.ReadAllText(filename);
            //    Console.WriteLine(text);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Chyba čtení souboru");
            //}

            string filename = @"d:\Temp\PR1\vystup.txt";

            //string text = "Zde je text" + System.Environment.NewLine;

            //File.AppendAllText(filename, text);

            string[] lines = new string[] { "jedna", "dva", "tři" };
            //File.WriteAllLines(filename, lines);
            //File.AppendAllLines(filename, lines);

            using (StreamWriter file = new StreamWriter(filename, append: true))
            {
                foreach(string line in lines)
                {
                    file.WriteLine(line);
                    
                }
            }
        } 
    }
}
