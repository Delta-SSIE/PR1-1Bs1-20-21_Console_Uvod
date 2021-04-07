using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Umisteny_obdelnik
{
    class Obdelnik
    {
        
        private double _stranaA;
        private double _stranaB;

        public double StranaA
        {
            get
            {
                return _stranaA;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _stranaA = value;
            }
        }
        public double StranaB
        {
            get
            {
                return _stranaB;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _stranaB = value;
            }
        }

        public Bod LevyHorni
        {
            get; private set;
        }
        public Bod PravyHorni
        {
            get
            {
                return new Bod(LevyHorni.X + _stranaA, LevyHorni.Y);
            }            
        }
        public Bod LevyDolni
        {
            get
            {
                return new Bod(LevyHorni.X, LevyHorni.Y - _stranaB);
            }            
        }
        public Bod PravyDolni
        {
            get
            {
                return new Bod(LevyHorni.X + _stranaA, LevyHorni.Y - _stranaB);
            }            
        }

        public Obdelnik(double stranaA, double stranaB, Bod levyHorni)
        {
            StranaA = stranaA;
            StranaB = stranaB;
            LevyHorni = levyHorni;
        }
        public Obdelnik(Bod levyHorni, Bod pravyDolni)
        {
            LevyHorni = levyHorni;
            StranaA = pravyDolni.X - levyHorni.X;
            StranaB = levyHorni.Y - pravyDolni.Y;
        }

        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }

        public double Obsah()
        {
            return _stranaA * _stranaB;
        }
    }
}
