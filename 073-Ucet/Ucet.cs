using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Ucet
{
    class Ucet
    {
        private double _zustatek = 0;

        public double Zustatek
        {
            get
            {
                return _zustatek;
            }
        }

        public void Uloz(double kolik)
        {
            if (kolik > 0)
                _zustatek += kolik;

            else
                throw new ArgumentOutOfRangeException();
        }
        public bool Vyber(double kolik)
        {
            if (kolik < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (kolik <= Zustatek)
            {
                _zustatek -= kolik;
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public void Urokuj(double urokovaMira) //uroklova mira je třeba 10
        {
            //_zustatek += _zustatek * urokovaMira / 100;
            _zustatek *= (1 + urokovaMira / 100);
        }

    }
}
