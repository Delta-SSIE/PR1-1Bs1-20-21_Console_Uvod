using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_Kruznice_Vlastnosti
{
    class Kruznice
    {
        private double _polomer;

        public double Polomer
        {
            get
            {
                return _polomer;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _polomer = value;
            }
        }

        public Kruznice (double polomer)
        {
            this.Polomer = polomer;
        }

        public double Obvod
        {
            get
            {
                return 2 * Math.PI * _polomer;
            }            
        }

        public double Obsah
        {
            get
            { 
                return Math.PI * _polomer * _polomer;
            }
        }
    }
}
