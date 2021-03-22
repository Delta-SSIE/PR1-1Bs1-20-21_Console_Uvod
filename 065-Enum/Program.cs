using System;

namespace _065_Enum
{
    enum Obdobi:byte { Jaro = 1, Leto, Podzim, Zima };
    class Program
    {
        static void Main(string[] args)
        {
            Obdobi chladne = Obdobi.Jaro;
            Console.WriteLine(chladne);

            chladne++;
            Console.WriteLine(chladne);

            Obdobi horke = (Obdobi) 1;
            Console.WriteLine(horke);

            Obdobi divne = (Obdobi)255;
            Console.WriteLine(divne);
           
        }
    }
}
