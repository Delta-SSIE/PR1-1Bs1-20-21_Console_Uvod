using System;

namespace _013_den_v_tydnu
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;

            // nedovolím nic jiného než 1-7, budu se ptát znova
            while (cislo < 1 || cislo > 7) { 
                // chci po uživateli číslo 1-7
                Console.WriteLine("Zadej číslo 1-7");
                cislo = int.Parse(Console.ReadLine());
            }

            string den;
            // pak řeknu, který den tomu odpovídá
            switch (cislo)
            {
                case 1:
                    den = "pondělí";
                    break;
                case 2:
                    den = "úterý";
                    break;
                case 3:
                    den = "středa";
                    break;
                case 4:
                    den = "čtvrtek";
                    break;
                case 5:
                    den = "pátek";
                    break;
                case 6:
                    den = "sobota";
                    break;
                case 7:
                    den = "neděle";
                    break;
                default:
                    den = "nějaký divný den";
                    break;
            }

            Console.WriteLine($"Dnes je {den}.");

        }
    }
}
