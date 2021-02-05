using System;

namespace _054_2D_pole_maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole1 = new int[,]
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 3, 7, 12 },
                { 13, 5, 18 },
                { 17, 0, 4 }
            };

            int[,] pole2 = new int[,]
            {
                { -1, -2, -3 },
                { -2, -3, -4 },
                { -3, -7, -12 },
                { -13, -5, -18 },
                { -17, -1, -4 }
            };

            int[] max1 = MaximumV2DPoli(pole1);
            Console.WriteLine( max1[0] + " " + max1[1] );
            //Console.WriteLine("[{0}, {1}]", max1[0], max1[1]);

            Console.WriteLine(String.Join(",", max1));

            Console.WriteLine( MaximumV2DPoli(pole2) );
        }

        static int[] MaximumV2DPoli(int[,] pole)
        {
            int maximum = pole[0, 0];
            int[] souradnice = { 0, 0 };

            //projdu celé pole, budu zvyšovat maximum
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (pole[i,j] > maximum)
                    {
                        maximum = pole[i, j];
                        souradnice[0] = i;
                        souradnice[1] = j;
                    }
                }
            }

            return souradnice;
        }

    }
}
