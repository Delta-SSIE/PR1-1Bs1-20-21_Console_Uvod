using System;

namespace _076_Naval_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            NavalBattle game = new NavalBattle();

            while (!game.IsFinished)
            {
                game.Turn();
            }

            game.FinalReport();

            Console.ReadKey();
        }
    }
}
