using System;

namespace _035_Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            //string bin = "10010001";
            string bin = "11111111";          

            //projdi řetězec odzadu            
            int cislo = 0;


            for (int i = bin.Length - 1, hodnota = 1; i >= 0; i--, hodnota *= 2)
            {
                //když je v řetězci 1, přičti hodnotu
                if (bin[i] == '1')
                {
                    cislo += hodnota;
                }

                // první pozice má hodnotu 1
                // každá další dvojnásobnou                
            }

            Console.WriteLine($"Binární {bin} je dekadicky {cislo}");

            Console.WriteLine(Convert.ToInt32(bin, 2));


        }
    }
}
