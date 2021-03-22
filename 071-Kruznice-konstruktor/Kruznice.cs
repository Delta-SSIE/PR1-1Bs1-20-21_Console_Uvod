using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_Kruznice_konstruktor
{
    class Kruznice
    {
        //datová položka
        private double _polomer;

        //setter
        public void NastavPolomer(double hodnota)
        {
            //ověříme, že je v pořádku
            if (hodnota < 0)
                throw new ArgumentOutOfRangeException();

            //vím, že je OK
            _polomer = hodnota;
        }

        //getter
        public double VratPolomer()
        {
            return _polomer;
        }

        public Kruznice()
        {
            _polomer = 0;
        }
        public Kruznice(double polomer)
        {
            NastavPolomer(polomer);
        }

        //metoda
        public double Obvod()
        {
            return 2 * Math.PI * _polomer;
        }

        public double Obsah()
        {
            return Math.PI * _polomer * _polomer;
        }
    }

}
