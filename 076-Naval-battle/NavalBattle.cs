using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Naval_battle
{
    class NavalBattle
    {
        const int MapWidth = 10;
        const int MapHeight = 10;
        const int Ships = 12;
        const int Wait = 150;

        private Player _player;
        private Player _computer;

        private Player _waitingPlayer;

        private Display _playerDisplay;
        private Display _computerDisplay;

        public bool IsFinished
        {
            get
            {
                return !_player.IsAlive || !_computer.IsAlive;
            }
        }

        public NavalBattle()
        {
            Console.CursorVisible = false;

            _player = new Player(MapWidth, MapHeight, Ships);
            _computer = new Player(MapWidth, MapHeight, Ships);

            _waitingPlayer = _computer;

            _playerDisplay = new Display(1, 1, MapWidth, MapHeight);
            _computerDisplay = new Display(MapWidth + 4, 1, MapWidth, MapHeight);

            _playerDisplay.RenderMap(_player.Map);
            _computerDisplay.RenderMap(_computer.PublicMap);
        }


        public void Turn()
        {
            Report();

            System.Threading.Thread.Sleep(Wait);

            if (_waitingPlayer == _player)
            {
                Coordinates target = _computer.RandomTarget(_player.PublicMap);
                bool hit = _player.HandleShot(target);
                _playerDisplay.RenderSector(target, _player.Map[target.X, target.Y]);
                if (!hit)
                    _waitingPlayer = _computer;
            }
            else
            {
                Coordinates target = _computerDisplay.GetLocationFromKbd(_computer.PublicMap);
                bool hit = _computer.HandleShot(target);
                _computerDisplay.RenderSector(target, _computer.PublicMap[target.X, target.Y]);
                if (!hit)
                    _waitingPlayer = _player;
            }
        }

        private void Report()
        {
            _computerDisplay.RenderScore(_computer.GetScore(), _waitingPlayer == _computer);
            _playerDisplay.RenderScore(_player.GetScore(), _waitingPlayer == _player);
        }

        public void FinalReport()
        {
            Report();

            Console.SetCursorPosition(0, MapHeight + 6);
            if (_player.IsAlive)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose!");

        }
    }
}
