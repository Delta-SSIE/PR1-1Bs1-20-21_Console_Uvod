using System;

namespace _016_do_while_kolik_do_sestky
{
    class Program
    {
        static void Main(string[] args)
        {
            // spočítej, kolikrát musíš hodit kostkou, než padne 6
            int pocitadlo = 0; // nastavím počítadlo

            Random generator = new Random(); // vytvořím generátor
            int hod;

            do
            {
                pocitadlo++; // zvýším počítadlo
                hod = generator.Next(1, 7); // hodím si
                Console.WriteLine(hod); //vypíšu
            }
            while (hod != 6); // budu opakovat, dokud nepadne 6

            Console.WriteLine("Počet hodů byl {0}", pocitadlo);
        }
    }
}
