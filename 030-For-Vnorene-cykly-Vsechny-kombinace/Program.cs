using System;

namespace _030_For_Vnorene_cykly_Vsechny_kombinace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jakou kombinací odemknout zámek?");
            string kombinace = "";
            bool nalezeno = false;

            for (int i = 0; i < 10 && !nalezeno; i++)
            {
                for (int j = 0; j < 10 && !nalezeno; j++)
                {
                    for (int k = 0; k < 10 && !nalezeno; k++)
                    {
                        kombinace = "" + i + j + k;
                        nalezeno = Odemkni(kombinace);
                    }
                }
            }

            Console.WriteLine($"Řešení je {kombinace}");

        }

        static bool Odemkni(string kombinace)
        {
            return kombinace == "734";
        }
    }
}
