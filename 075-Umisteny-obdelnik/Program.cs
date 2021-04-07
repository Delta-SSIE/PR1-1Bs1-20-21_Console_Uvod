using System;

namespace _075_Umisteny_obdelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik obdABCD = new Obdelnik(4, 3, new Bod(3, 5));

            Console.WriteLine($"Rohy obdélníka jsou {obdABCD.LevyHorni}, {obdABCD.PravyHorni}, {obdABCD.PravyDolni}, {obdABCD.LevyDolni}");

            Obdelnik obdEFGH = new Obdelnik(new Bod(0, 0), new Bod(1, -1));
            Console.WriteLine($"Rohy obdélníka jsou {obdEFGH.LevyHorni}, {obdEFGH.PravyHorni}, {obdEFGH.PravyDolni}, {obdEFGH.LevyDolni}");

            Obdelnik obdIJKL = new Obdelnik(new Bod(0, 0), new Bod(1, 1));
        }
    }
}
