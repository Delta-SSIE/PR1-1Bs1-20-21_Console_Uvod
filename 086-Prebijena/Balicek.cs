using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_Prebijena
{
    class Balicek
    {
        private Queue<Karta> _karty = new Queue<Karta>();

        //pocet karet
        public int PocetKaret
        {
            get
            {
                return _karty.Count;
            }
        }

        //napln -- vytvoř všechny karty
        public void Napln()
        {
            _karty.Clear();

            for (byte vyska = 0; vyska < 8; vyska++)
            {
                for (int barva = 0; barva < 4; barva++)
                {
                    Karta karta = new Karta((VyskaKarty)vyska, (BarvaKarty)barva);
                    _karty.Enqueue(karta);
                }
            }
        }

        //zamichej
        public void Zamichej()
        {
            Random random = new Random();
            Karta[] tmpBalicek = _karty.ToArray();
            tmpBalicek = tmpBalicek.OrderBy(k => random.NextDouble()).ToArray();
            _karty = new Queue<Karta>(tmpBalicek);
        }

        //vezmiKartu
        public Karta VezmiKartu()
        {
            return _karty.Dequeue();
        }

        //dejDospod
        public void DejDospod(Karta karta)
        {
            _karty.Enqueue(karta);
        }

        //vypis
        public void Vypis()
        { 
            foreach (Karta karta in _karty) 
            {
                Console.WriteLine(karta);
            }
        }
    }
}
