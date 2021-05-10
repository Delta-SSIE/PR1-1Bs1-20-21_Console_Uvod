using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_Prebijena
{
    class Hra
    {
        //nová hra
        public Balicek Hrac1;
        public Balicek Hrac2;

        private Random _random = new Random();

        //je konec?
        public bool JeKonec
        {
            get
            {
                return Hrac1.PocetKaret == 0 || Hrac2.PocetKaret == 0;
            }
        }

        //rozdej
        public void Rozdej()
        {
            Balicek vsechnyKarty = new Balicek();
            vsechnyKarty.Napln();
            vsechnyKarty.Zamichej();

            Hrac1 = new Balicek();
            Hrac2 = new Balicek();

            Balicek komu = Hrac1;
            while (vsechnyKarty.PocetKaret > 0)
            {
                komu.DejDospod(vsechnyKarty.VezmiKartu());
                if (komu == Hrac1)
                    komu = Hrac2;
                else
                    komu = Hrac1;

                //komu = komu == Hrac1 ? Hrac2 : Hrac1;

            }
        }


        //odehraj jedno kolo
        public void Kolo()
        {
            //Porovnani vysledek = Porovnani.ObeStejne;
            List<Karta> vylozeno = new List<Karta>();

            while (!JeKonec)
            {
                //oba vezmou karty
                Karta karta1 = Hrac1.VezmiKartu();
                Console.WriteLine($"Hráč 1 nese {karta1}");

                Karta karta2 = Hrac2.VezmiKartu();
                Console.WriteLine($"Hráč 2 nese {karta2}");

                if (_random.Next(2) == 0)
                { 
                    vylozeno.Add(karta1);
                    vylozeno.Add(karta2);
                }
                else
                {
                    vylozeno.Add(karta2);
                    vylozeno.Add(karta1);
                }

                //porovnaji je

                //kdyz ma jeden vyssi bere vse
                if (karta1 > karta2)
                {
                    Console.WriteLine("Bere hráč 1");
                    foreach (Karta k in vylozeno)
                    {
                        Hrac1.DejDospod(k);
                    }
                    break;
                }
                else if (karta1 < karta2)
                {
                    Console.WriteLine("Bere hráč 2");
                    foreach (Karta k in vylozeno)
                    {
                        Hrac2.DejDospod(k);
                    }
                    break;
                }
                //pri shodnosti se opakuje

            }
        }

        //vypis vysledky
        public void VypisVysledek()
        {
            if (!JeKonec)
                Console.WriteLine("Hra ještě neskončila");
            else if (Hrac1.PocetKaret == 0)
                Console.WriteLine("Vyhrál hráč B");
            else
                Console.WriteLine("Vyhrál hráč A");
        }
    }
}
