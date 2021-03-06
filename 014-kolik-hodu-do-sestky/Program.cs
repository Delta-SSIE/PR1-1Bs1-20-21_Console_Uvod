﻿using System;

namespace _014_kolik_hodu_do_sestky
{
    class Program
    {
        static void Main(string[] args)
        {
            // spočítej, kolikrát musíš hodit kostkou, než padne 6
            int pocitadlo = 1; // nastavím počítadlo

            Random generator = new Random(); // vytvořím generátor
            int hod = generator.Next(1, 7); // hodím si
            Console.WriteLine(hod); // vypíšu

            while (hod != 6) // budu opakovat, dokud nepadne 6
            {
                pocitadlo++; // zvýším počítadlo
                hod = generator.Next(1, 7); // hodím si
                Console.WriteLine(hod); //vypíšu
            }

            Console.WriteLine("Počet hodů byl {0}", pocitadlo);

        }
    }
}
