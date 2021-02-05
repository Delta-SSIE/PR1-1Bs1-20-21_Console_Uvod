using System;

namespace _053_2D_pole_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[3, 2];

            // int[] pole2 = { 1, 2, 3, 4 }; //jednoduché pole

            int[,] pole3 =
            {
                { 0, 1, 2 },
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 3, 4, 5 }
            };

            pole[1, 0] = 6;
            //Console.WriteLine(pole[1,0]);

            Vypis2DPole(pole);
            Console.WriteLine();
            Vypis2DPole(pole3);

        }

        public static void Vypis2DPole(int[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
