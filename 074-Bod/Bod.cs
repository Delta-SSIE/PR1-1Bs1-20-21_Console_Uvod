using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Bod
{
    class Bod
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Bod(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            Bod jinyBod = (Bod) obj;
            return this.X == jinyBod.X && this.Y == jinyBod.Y;
        }

        //public bool ShodnyS(Bod jinyBod)
        //{
        //    return this.X == jinyBod.X && this.Y == jinyBod.Y;
        //}

        public double VzdalenostOd(Bod druhyBod)
        {
            double dx = this.X - druhyBod.X;
            double dy = this.Y - druhyBod.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"Bod [{X};{Y}]";
        }
    }
}
