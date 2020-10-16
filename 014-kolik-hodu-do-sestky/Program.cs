using System;

namespace _014_kolik_hodu_do_sestky
{
    class Program
    {
        static void Main(string[] args)
        {
            // spočítej, kolikrát musíš hodit kostkou, než padne 6
            int pocitadlo = 1;
            Random generator = new Random();
            int hod = generator.Next(1, 7);
            Console.WriteLine(hod);
            
            while ( hod != 6 )
            {
                pocitadlo++;
                hod = generator.Next(1, 7);
                Console.WriteLine(hod);
            }

            Console.WriteLine("Počet hodů byl {0}", pocitadlo);

        }
    }
}
