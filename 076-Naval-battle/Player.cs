using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Naval_battle
{
    class Player
    {
        private static Random random = new Random();

        public SectorState[,] Map { get; private set; }
        /// <summary>
        /// Shows water, where opponent has not shot
        /// </summary>
        public SectorState[,] PublicMap
        {
            get
            {
                SectorState[,] publicMap = new SectorState[_mapWidth, _mapHeight];
                for (int x = 0; x < _mapWidth; x++)
                {
                    for (int y = 0; y < _mapHeight; y++)
                    {
                        if (Map[x, y] == SectorState.Ship)
                            publicMap[x, y] = SectorState.Water;
                        else
                            publicMap[x, y] = Map[x, y];
                    }
                }
                return publicMap;
            }
        }

        public int TotalShips { get; private set; }
        public int Wrecks { get; private set; }

        public bool IsAlive
        {
            get
            {
                return Wrecks < TotalShips;
            }
        }

        private int _mapWidth;
        private int _mapHeight;

        public Player(int mapWidth, int mapHeight, int totalShips)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            TotalShips = totalShips;
            Wrecks = 0;

            Map = new SectorState[mapWidth, mapHeight];
            PlaceShips();
        }

        public void PlaceShips()
        {
            int shipsToPlace = TotalShips;
            while (shipsToPlace > 0)
            {
                //random coordinates within map
                int x = random.Next(_mapWidth);
                int y = random.Next(_mapHeight);

                //if empty, place ship
                if (Map[x,y] == SectorState.Water)
                {
                    Map[x, y] = SectorState.Ship;
                    shipsToPlace--;
                }
            }
        }

        /// <summary>
        /// Handles shot to given coordinates
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True, if hit a new ship, False otherwise</returns>
        public bool HandleShot(Coordinates target)
        {
            SectorState state = Map[target.X, target.Y];

            switch (state)
            {
                case SectorState.Water:
                    Map[target.X, target.Y] = SectorState.Shot;
                    return false;

                case SectorState.Ship:
                    Map[target.X, target.Y] = SectorState.Wreck;
                    Wrecks++;
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Finds random place that has nbot been hit yet
        /// </summary>
        /// <param name="opponentMap"></param>
        /// <returns></returns>
        public Coordinates RandomTarget(SectorState[,] opponentMap)
        {
            Coordinates target = new Coordinates();
            do
            {
                target.X = random.Next(opponentMap.GetLength(0));
                target.Y = random.Next(opponentMap.GetLength(1));
            }
            while (opponentMap[target.X, target.Y] != SectorState.Water);
            return target;
        }

        public string GetScore()
        {
            return $"Hits: {Wrecks}/{TotalShips}";
        }

    }
}
