using System;

namespace _008_vetsi_podminka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Oblíbená barva: ");
            string barva = Console.ReadLine();

            if (barva == "modrá")
            {
                Console.WriteLine("Modrá je dobrá");
            }
            else if (barva == "zelená")
            {
                Console.WriteLine("Zelená je nebezpečná");
            }
            else if (barva == "červená")
            {
                Console.WriteLine("Červená je nudná a fádní");
            }
            else
            {
                Console.WriteLine("Tuhle barvu radši ani neznám");
            }
        }
    }
}
