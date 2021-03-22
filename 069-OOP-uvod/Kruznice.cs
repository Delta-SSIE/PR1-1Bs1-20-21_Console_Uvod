using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_OOP_uvod
{
    class Kruznice
    {
        //datová položka
        public double Polomer = 0;

        //metoda
        public double Obvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double Obsah()
        {
            return Math.PI * Polomer * Polomer;
        }
    }
}
