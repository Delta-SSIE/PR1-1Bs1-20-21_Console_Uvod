using System;

namespace _056_Minesweeper
{
    class Program
    {
        const string znakMina = "*";
        const string znakPraporek = "P";
        const string znakPrazdno = " ";
        const string znakNeodkryto = ".";

        static void Main(string[] args)
        {
            const int vyska = 8;
            const int sirka = 8;
            const int pocetMin = 15;

            //vygenerujeme mapu
            bool[,] mapaMin = VytvorMapu(vyska, sirka, pocetMin);

            //spocitame mapu sousedu
            byte[,] sousede = Sousede(mapaMin);

            //pripravim mapu pro hrace
            byte[,] mapaHrace = new byte[vyska, sirka]; //0 - neodkryto, 1 - odkryto, 2 - oznaceno, 3 - bum

            byte kurzorX = sirka / 2;
            byte kurzorY = vyska / 2;

            bool jeKonec = false;
            bool vybuchnul = false;

            int[] statistika = SpoctiStatistiku(mapaHrace);

            while (!jeKonec)
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine($"Označeno min {statistika[1]} /  {pocetMin}");
                Console.WriteLine();

                //vykresli
                KresliMapu(mapaHrace, sousede, kurzorX, kurzorY);

                //nacti vstup
                ConsoleKeyInfo stisknuto = Console.ReadKey();

                //zpracuj
                switch (stisknuto.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (kurzorY > 0)
                            kurzorY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (kurzorY < vyska - 1)
                            kurzorY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (kurzorX > 0)
                            kurzorX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (kurzorX <sirka - 1)
                            kurzorX++;
                        break;

                    case ConsoleKey.Spacebar: //oznac/odznac
                        if (mapaHrace[kurzorY, kurzorX] == 0)
                            mapaHrace[kurzorY, kurzorX] = 2;
                        else if (mapaHrace[kurzorY, kurzorX] == 2)
                            mapaHrace[kurzorY, kurzorX] = 0;
                        break;

                    case ConsoleKey.Enter: //odkryj
                        if (mapaHrace[kurzorY, kurzorX] == 2)
                            break;
                        bool jeMina = mapaMin[kurzorY, kurzorX];
                        if (jeMina)
                        {
                            mapaHrace[kurzorY, kurzorX] = 3;
                            vybuchnul = true;
                        }
                        else
                        {
                            mapaHrace[kurzorY, kurzorX] = 1;
                        }
                        break;
                }

                statistika = SpoctiStatistiku(mapaHrace);

                if (vybuchnul)
                    jeKonec = true;

                //ukončím hru, pokud nevybuchul když je součet označených a odkrytých polí roven celkovému
                //počtu polí
                else if ( (statistika[0] + statistika[1]) == vyska * sirka && statistika[1] == pocetMin)
                    jeKonec = true;
            }

            Console.Clear();
            KresliMapu(mapaHrace, sousede);
            Console.WriteLine();

            if (vybuchnul)
                Console.WriteLine("Šlápl jsi na minu!");
            else
                Console.WriteLine("Vyhrál jsi!");

        }

        /// <summary>
        /// Vykreslí mapu počtu sousedů každého políčka, pokud je hráč odkryl, a jeho značky min
        /// </summary>
        /// <param name="mapaHrace">2D pole označující stav každého políčka z pohledu hráče (odkryto/označeno</param>
        /// <param name="mapaSousedu">2D pole s počty sousedních min ke každému políčku</param>
        /// <param name="kurzorX">X pozice kurzoru v poli</param>
        /// <param name="kurzorY">X pozice kurzoru v poli</param>
        static void KresliMapu(byte[,] mapaHrace, byte[,] mapaSousedu, int kurzorX = -1, int kurzorY = -1)
        {
            int sirka = mapaHrace.GetLength(1);
            int vyska = mapaHrace.GetLength(0);
            Console.WriteLine(" ╔" + "".PadRight(sirka, '═') + '╗');
            for (int y = 0; y < vyska; y++)
            {
                Console.Write(" ║");
                for (int x = 0; x < sirka; x++)
                {
                    if (x == kurzorX && y == kurzorY)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    byte stav = mapaHrace[y, x];
                    string symbol;
                    if (stav == 0) //neodkryto
                        symbol = znakNeodkryto;
                    else if (stav == 1) //odkryto - zobraz číslo
                    {
                        symbol = mapaSousedu[y, x].ToString();
                        if (symbol == "0")
                            symbol = znakPrazdno;
                    }
                    else if (stav == 2)
                    {
                        symbol = znakPraporek;
                    }
                    else
                        symbol = znakMina;

                    Console.Write(symbol);

                    if (x == kurzorX && y == kurzorY)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.Write("║");
                Console.WriteLine();
            }
            Console.WriteLine(" ╚" + "".PadRight(sirka, '═') + '╝');
        }

        /// <summary>
        /// Vygeneruje mapu s náhodně rozmístěnými hodnotami true
        /// </summary>
        /// <param name="vyska"></param>
        /// <param name="sirka"></param>
        /// <param name="pocetMin"></param>
        /// <returns>2D pole s polohami min</returns>
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMin)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];
            for (int i = 0; i < pocetMin; i++)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (mapa[y, x])
                {
                    i--;
                }
                else
                {
                    mapa[y, x] = true;
                }
            }
            return mapa;
        }

        /// <summary>
        /// Spočte ke každému logického poli, kolik okolních políček je zaminováno - má hodnotu true
        /// </summary>
        /// <param name="mapa">Mapa poloh min</param>
        /// <returns>2D pole s počtem sousedů každého políčka</returns>
        static byte[,] Sousede(bool[,] mapa)
        {
            int vyska = mapa.GetLength(0);
            int sirka = mapa.GetLength(1);

            byte[,] poleSousedu = new byte[vyska, sirka];

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    poleSousedu[y, x] = PocetSousedu(mapa, x, y);
                }
            }

            return poleSousedu;
        }

        /// <summary>
        /// Určí počet hodnot true v předaném poli
        /// </summary>
        /// <param name="mapa">Pole logických hodnot - poloh min</param>
        /// <param name="sourX">Souřadnice X políčka</param>
        /// <param name="sourY">Souřadnice Y políčka</param>
        /// <returns></returns>
        static byte PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            byte pocet = 0;

            for (int posunX = -1; posunX < 2; posunX++)
            {
                for (int posunY = -1; posunY < 2; posunY++)
                {
                    if (posunX == 0 && posunY == 0)
                        continue;
                    int poziceX = sourX + posunX;
                    int poziceY = sourY + posunY;

                    if (poziceX < 0 || poziceX >= mapa.GetLength(1) || poziceY < 0 || poziceY >= mapa.GetLength(0))
                        continue;

                    if (mapa[poziceY, poziceX])
                        pocet++;
                }
            }

            return pocet;
        }

        /// <summary>
        /// Vrátí informaci, kolik polí bylo odkryto kolik označeno jako mina
        /// </summary>
        /// <param name="mapaHrace">2D pole se stavem hráčovy mapy (1 - odkryto, 2 - označeno)</param>
        /// <returns>2-prvkové pole se součty (index 0: odkryto, index 1: označeno)</returns>
        static int[] SpoctiStatistiku(byte[,] mapaHrace)
        {
            int vyska = mapaHrace.GetLength(0);
            int sirka = mapaHrace.GetLength(1);

            int oznaceno = 0;
            int odkryto = 0;

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    if (mapaHrace[y, x] == 1)
                        odkryto++;
                    else if (mapaHrace[y, x] == 2)
                        oznaceno++;
                }
            }

            int[] statistika = new int[] { odkryto, oznaceno };
            return statistika;
        }
    }
}
