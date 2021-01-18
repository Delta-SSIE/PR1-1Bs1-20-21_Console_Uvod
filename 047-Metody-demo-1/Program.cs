﻿using System;

namespace _047_Metody_demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //generátor náhodných čísel

            //připravím "počítadla"
            int kolo = 0;
            int skoreHrac = 0;
            int skorePC = 0;

            int hracKamen = 0;
            int hracNuzky = 0;
            int hracPapir = 0;

            //tento řetězec budu plnit při dotazu na konec hry
            string hratDalsi;

            do
            {
                kolo++; //zvýším kolo o 1

                //vypíšu informace
                Console.WriteLine();
                Console.WriteLine($"{kolo}. kolo: ");
                Console.WriteLine();

                string figuraHrac = NactiFiguruHrace();
                string figuraPC = VygenerujFiguruPC(rnd, hracKamen, hracNuzky, hracPapir);

                int vitez = VyberViteze(figuraHrac, figuraPC);
                if (vitez == 1)
                { 
                    skoreHrac++;
                }
                else if (vitez == 2)
                {
                    skorePC++;
                }

                if (figuraHrac == "k")
                {
                    hracKamen++;
                }
                else if (figuraHrac == "n")
                {
                    hracNuzky++;
                }
                else
                {
                    hracPapir++;
                }

                //podám informaci o stavu
                Console.WriteLine($"Průběžné skore Hráč: {skoreHrac} - PC: {skorePC}");

                //zjistím, zda chce skončit
                do
                {
                    Console.Write("Chceš hrát další kolo? (a/n): ");
                    hratDalsi = Console.ReadLine().ToLower();
                }
                while (hratDalsi != "a" && hratDalsi != "n");
                //při neplatné odpovědi se ptám znovu

            }
            while (hratDalsi == "a");
            //dokud chce hrát další, opakuji


            //vypíšu závěrečné informace
            Console.WriteLine();
            Console.WriteLine($"Závěřečné skore po {kolo} kolech - Hráč: {skoreHrac} - PC: {skorePC}");

        }

        /// <summary>
        /// Načte od hráče vstup, nedovolí vložit nic, než k/n/p
        /// </summary>
        /// <returns>figura jako 1 znak k - n - p</returns>
        static string NactiFiguruHrace()
        {
            string figuraHrac;
            do
            {
                //vyzvu hráče k zadání
                Console.Write("Zvol figuru (k/n/p): ");
                //převedu na malé písmeno (pro jistotu - nevím, zda dal velké nebo malé)
                figuraHrac = Console.ReadLine().ToLower();
            }
            while (figuraHrac != "k" && figuraHrac != "n" && figuraHrac != "p");
            //pokud nezadal něco smysluplného, budu načítat znovu
            return figuraHrac;
        }

        /// <summary>
        /// Vytvoří figuru pro PC na základě statistik předchozí hry hráče
        /// </summary>
        /// <param name="rnd">generátor náh. čísel</param>
        /// <param name="hracKamen">Kolikrát hráč vložil kámen</param>
        /// <param name="hracNuzky">Kolikrát hráč vložil nůžky</param>
        /// <param name="hracPapir">Kolikrát hráč vložil papír</param>
        /// <returns>figura jako 1 znak k - n - p</returns>
        static string VygenerujFiguruPC(Random rnd, int hracKamen, int hracNuzky, int hracPapir)
        {
            string figuraPC;
            if (hracKamen > hracNuzky && hracKamen > hracPapir)
            {
                figuraPC = "p";
            }
            else if (hracNuzky > hracKamen && hracNuzky > hracPapir)
            {
                figuraPC = "k";
            }
            else if (hracPapir > hracKamen && hracPapir > hracNuzky)
            {
                figuraPC = "n";
            }
            else if (hracKamen < hracNuzky && hracKamen < hracPapir)
            {
                int hod = rnd.Next(0, 2);
                figuraPC = (hod == 0) ? "k" : "n";
            }
            else if (hracNuzky < hracKamen && hracNuzky < hracPapir)
            {
                int hod = rnd.Next(0, 2);
                figuraPC = (hod == 0) ? "p" : "n";
            }
            else if (hracPapir < hracNuzky && hracPapir < hracKamen)
            {
                int hod = rnd.Next(0, 2);
                figuraPC = (hod == 0) ? "k" : "p";
            }
            else
            {
                int hod = rnd.Next(0, 3);
                figuraPC = (hod == 0) ? "k" :
                            (hod == 1) ? "n" :
                            "p";
            }
            return figuraPC;
        }

        /// <summary>
        /// Vybere vítěze podle figury
        /// </summary>
        /// <param name="figuraHrac"></param>
        /// <param name="figuraPC"></param>
        /// <returns>0 pro remízu, 1 pro hráče, 2 pro počítač</returns>
        static int VyberViteze(string figuraHrac, string figuraPC)
        {
            if (figuraHrac == figuraPC)
            {
                Console.WriteLine($"Remíza ({figuraHrac}:{figuraPC})");
                return 0;
            }
            else if (
                (figuraHrac == "k" && figuraPC == "n") ||
                (figuraHrac == "n" && figuraPC == "p") ||
                (figuraHrac == "p" && figuraPC == "k")
            )
            {
                Console.WriteLine($"Vyhrál jsi ({figuraHrac}:{figuraPC})");
                return 1;
            }
            else
            {
                Console.WriteLine($"Vyhrál jsem ({figuraHrac}:{figuraPC})");
                return 2;
            }
        }
    }
}
