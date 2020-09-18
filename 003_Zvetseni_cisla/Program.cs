using System;

namespace _003_zvetseni_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo");

            //string nacteno; // vytvořím proměnnou, neinicializuju
            //nacteno = Console.ReadLine(); // načtu do řetězcové proměnné

            //int cislo; // vytvořím číselnou proměnnou, neinicializuju
            //cislo = int.Parse(nacteno); // načtu z klávesnice, uložím do proměnné
            //cislo = cislo + 1; // zvětším o 1 a uložím zpět

            //Console.WriteLine("Zvětšeno: " + cislo); //slepím řetězce a vypíšu
            //Console.WriteLine("Ukazka: " + nacteno + 1);


            //Console.WriteLine("Zvětšeno: " + (int.Parse(Console.ReadLine()) + 1)); //slepím řetězce a vypíšu


            int cislo = int.Parse(Console.ReadLine()); // vytvořím číselnou proměnnou
            // uložím do ní parsovaný vstup z klávesnice
            cislo = cislo + 1; // zvětším o 1 a uložím zpět
            Console.WriteLine("Zvětšeno: " + cislo); //slepím řetězce a vypíšu


        }
    }
}
