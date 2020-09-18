using System;

namespace _003_zvetseni_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo");


            /* "Ukecaný" způsob */

            /* 
            string nacteno; // vytvořím proměnnou, neinicializuju
            nacteno = Console.ReadLine(); // načtu do řetězcové proměnné

            int cislo; // vytvořím číselnou proměnnou, neinicializuju
            cislo = int.Parse(nacteno); // načtu z klávesnice, uložím do proměnné
            cislo = cislo + 1; // zvětším o 1 a uložím zpět

            Console.WriteLine("Zvětšeno: " + cislo); //slepím řetězce a vypíšu
            Console.WriteLine("Ukazka: " + nacteno + 1);
            */



            /* Příliš "zhuštěný" způsob */

            //Console.WriteLine("Zvětšeno: " + (int.Parse(Console.ReadLine()) + 1)); 



            /* Zlatá střední cesta */

            // vytvořím číselnou proměnnou
            // a uložím do ní parsovaný vstup z klávesnice
            int cislo = int.Parse(Console.ReadLine()); 
                                                       
            cislo = cislo + 1; // zvětším o 1 a uložím zpět
            Console.WriteLine("Zvětšeno: " + cislo); //slepím řetězce a vypíšu

        }
    }
}
