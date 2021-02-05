using System;

namespace _055_max_radek
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

            Console.WriteLine(MaxRadek(pole1));
            Console.WriteLine(MaxSloupec(pole1));
            Console.WriteLine();

            int[,] pole2 = new int[,]
            {
                { -1, -2, -3 },
                { -2, -3, -4 },
                { -3, -7, -12 },
                { -13, -5, -18 },
                { -17, -1, -4 }
            };

            Console.WriteLine(MaxRadek(pole2));
            Console.WriteLine(MaxSloupec(pole2));
            Console.WriteLine();
        }

        static int MaxRadek(int[,] pole)
        {
            int indexRadku = 0;
            int maxSoucet = int.MinValue;

            for (int y = 0; y < pole.GetLength(0); y++) //vnější proměnná - řádky
            {
                int soucet = 0;

                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    soucet += pole[y, x];
                }

                if (soucet > maxSoucet)
                {
                    maxSoucet = soucet;
                    indexRadku = y;
                }
            }

            return indexRadku;
        }

        static int MaxSloupec(int[,] pole)
        {
            int indexSloupce = 0;
            int maxSoucet = int.MinValue;

            for (int x = 0; x < pole.GetLength(1); x++) //vnější proměnná - řádky
            {
                int soucet = 0;

                for (int y = 0; y < pole.GetLength(0); y++)
                {
                    soucet += pole[y, x];
                }

                if (soucet > maxSoucet)
                {
                    maxSoucet = soucet;
                    indexSloupce = x;
                }
            }

            return indexSloupce;
        }
    }
}
