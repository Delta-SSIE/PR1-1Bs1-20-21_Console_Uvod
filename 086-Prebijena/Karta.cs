using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_Prebijena
{
    enum VyskaKarty : byte { Sedma, Osma, Devitka, Desitka, Svrsek, Spodek, Kral, Eso };
    enum BarvaKarty : byte { Kule, Zaludy, Listy, Srdce };

    //enum Porovnani : byte { PrvniVetsi, ObeStejne, DruhaVetsi };

    class Karta
    {
        public Karta(VyskaKarty vyska, BarvaKarty barva)
        {
            Vyska = vyska;
            Barva = barva;
        }

        public VyskaKarty Vyska { get; private set; }
        public BarvaKarty Barva { get; private set; }

        public override string ToString()
        {
            return $"Karta ({Barva}, {Vyska})";
        }

        //public Porovnani SrovnejS(Karta jinaKarta)
        //{
        //    if (this.Vyska > jinaKarta.Vyska)
        //        return Porovnani.PrvniVetsi;
        //    else if (this.Vyska == jinaKarta.Vyska)
        //        return Porovnani.ObeStejne;
        //    else
        //        return Porovnani.DruhaVetsi;
        //}

        public static bool operator<(Karta k1, Karta k2)
        {
            return k1.Vyska < k2.Vyska;
        }

        public static bool operator>(Karta k1, Karta k2)
        {
            return k1.Vyska > k2.Vyska;
        }

        public static bool operator<=(Karta k1, Karta k2)
        {
            return k1.Vyska <= k2.Vyska;
        }

        public static bool operator>=(Karta k1, Karta k2)
        {
            return k1.Vyska >= k2.Vyska;
        }

    }
}
