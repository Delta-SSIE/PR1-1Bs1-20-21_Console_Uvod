using System;

namespace _068_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write( "Zadej číslo: " );
            //string nacteno = Console.ReadLine();
            //int cislo;
            //try
            //{
            //    cislo = int.Parse(nacteno);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bylo vloženo neplatné číslo, ukončuji chod");
            //    return;                
            //}

            //Console.WriteLine("Napsal jsi " + cislo);


            //System.DivideByZeroException

            Console.Write("Zadej číslo: ");
            string nacteno = Console.ReadLine();
            try
            {
                //int cislo = int.Parse(nacteno);
                //int c = Division(5, cislo);
                double cislo = double.Parse(nacteno);
                double c = DecimalDivision(5, cislo);
                Console.WriteLine("Podíl je {0}", c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Chybný formát čísla.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nulou nelze dělit");                
            }
            catch (Exception)
            {
                Console.WriteLine("Došlo k neznámé chybě programu");
            }

            static int Division(int a, int b)
            {
                return a / b;
            }

            static double DecimalDivision(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException();
                return a / b;
            }

        }
    }
}
