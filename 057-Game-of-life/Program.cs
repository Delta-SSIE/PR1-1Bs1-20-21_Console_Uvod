using System;

namespace _057_Game_of_life
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int pauza = 250;
            const int vyska = 30;
            const int sirka = 70;
            //const int pocet = 200;

            //udává, zda se má nebo nemá vypočítávat další generace a překreslovat
            bool hraBezi = true;

            //vytvořit mapu
            //bool[,] mapa = VytvorNahodnouMapu(vyska, sirka, pocet);
            bool[,] mapa = EditujMapu(vyska, sirka);

            //donekonečna v cyklu
            while(true)
            {

                if (hraBezi)
                {
                    //vykreslím mapu
                    Console.Clear();
                    VykresliMapu(mapa);

                    //vypočtu příští generaci
                    bool[,] pristiGenerace = new bool[mapa.GetLength(0), mapa.GetLength(1)];
                    for (int y = 0; y < mapa.GetLength(0); y++)
                    {
                        for (int x = 0; x < mapa.GetLength(1); x++)
                        {
                            //pro každou buňku spočítám sousedy
                            int sousede = PocetSousedu(mapa, x, y);
                            //a rozhodnu, zda bude živá
                            pristiGenerace[y, x] = BudeZiva(mapa[y, x], sousede);
                        }
                    }
                    mapa = pristiGenerace;
                }

                //chviličku počkám
                System.Threading.Thread.Sleep(pauza);
                //zjistím, jestli nebyla stisknuta klávesa
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        //mezerník pauzuje
                        hraBezi = !hraBezi;
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        //enter vstoupí do editace
                        mapa = EditujMapu(mapa);
                    }
                }
            }
        }

        /// <summary>
        /// Implementuje pravidla hry life
        /// </summary>
        /// <param name="jeZiva">je buňka živá s této generaci</param>
        /// <param name="pocetSousedu">kolik má živých sousedů</param>
        /// <returns>Zda bude buňka v příští generaci živá (true) nebo mrtvá (false)</returns>
        static bool BudeZiva(bool jeZiva, int pocetSousedu)
        {
            if (jeZiva)
            {
                if (pocetSousedu < 2 || pocetSousedu > 3)
                {
                    //Každá živá buňka s méně než dvěma živými sousedy zemře.
                    //Každá živá buňka s více než třemi živými sousedy zemře.
                    return false;
                }
                else
                {
                    //Každá živá buňka se dvěma nebo třemi živými sousedy zůstává žít.
                    return true;
                }
            }
            else
            {
                //Každá mrtvá buňka s právě třemi živými sousedy oživne.
                if (pocetSousedu == 3)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Zobrazí mapu s případnou značkou kurzoru
        /// </summary>
        /// <param name="mapa"></param>
        /// <param name="kurzorX"></param>
        /// <param name="kurzorY"></param>
        /// <param name="znakTrue"></param>
        /// <param name="znakFalse"></param>
        static void VykresliMapu(bool[,] mapa, int kurzorX = -1, int kurzorY = -1, char znakTrue = '#', char znakFalse = ' ')
        {
            int sirka = mapa.GetLength(1);
            int vyska = mapa.GetLength(0);
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
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
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
        /// Spočítá k předaným souřadnicím sousední živé buňky (sousedy počítá cyklicky - levý kraj zatočen napravo a naopak)
        /// </summary>
        /// <param name="mapa"></param>
        /// <param name="sourX"></param>
        /// <param name="sourY"></param>
        /// <returns>Počet živých sousedů</returns>
        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            int pocet = 0;

            for (int posunX = -1; posunX < 2; posunX++)
            {
                for (int posunY = -1; posunY < 2; posunY++)
                {
                    if (posunX == 0 && posunY == 0)
                        continue;
                    int poziceX = sourX + posunX;
                    int poziceY = sourY + posunY;

                    //if (poziceX < 0 || poziceX >= mapa.GetLength(1) || poziceY < 0 || poziceY >= mapa.GetLength(0))
                    //    continue;

                    if (poziceX < 0)
                        poziceX = mapa.GetLength(1) - 1;
                    else if (poziceX == mapa.GetLength(1))
                        poziceX = 0;

                    if (poziceY < 0)
                        poziceY = mapa.GetLength(0) - 1;
                    else if (poziceY == mapa.GetLength(0))
                        poziceY = 0;


                    if (mapa[poziceY, poziceX])
                        pocet++;
                }
            }

            return pocet;
        }

        /// <summary>
        /// Generuje mapu s náhodně rozmístěnými živými buňkami
        /// </summary>
        /// <param name="vyska"></param>
        /// <param name="sirka"></param>
        /// <param name="pocetZivych"></param>
        /// <returns></returns>
        static bool[,] VytvorNahodnouMapu(int vyska, int sirka, int pocetZivych)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];

            int umisteno = 0;

            while (umisteno < pocetZivych)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (!mapa[y, x])
                {
                    mapa[y, x] = true;
                    umisteno++;
                }
            }
            return mapa;
        }

        /// <summary>
        /// Interaktivně z klávesnice umožní změnit stav buněk v mapě a pak ji vrátí
        /// </summary>
        /// <param name="mapa"></param>
        /// <returns>Mapa po editaci</returns>
        static bool[,] EditujMapu(bool[,] mapa)
        {
            int vyska = mapa.GetLength(0);
            int sirka = mapa.GetLength(1);
            //bool[,] mapa = new bool[vyska, sirka];

            int kurzorX = sirka / 2;
            int kurzorY = vyska / 2;

            while(true)
            {
                Console.Clear();
                VykresliMapu(mapa, kurzorX, kurzorY);
                Console.WriteLine("Mezrník mění stav buňky, Enter spustí simulaci.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        mapa[kurzorY, kurzorX] = !mapa[kurzorY, kurzorX];
                        break;

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
                        if (kurzorX < sirka - 1)
                            kurzorX++;
                        break;

                    case ConsoleKey.Enter:
                        return mapa;
                }
            }
        }

        /// <summary>
        /// Vytvoří novou mapu zadaných rozměrů a pak interaktivně z klávesnice umožní změnit stav buněk v ní a mapu vrátí
        /// </summary>
        /// <param name="vyska"></param>
        /// <param name="sirka"></param>
        /// <returns></returns>
        static bool[,] EditujMapu(int vyska, int sirka)
        {
            bool[,] prazdnaMapa = new bool[vyska, sirka];
            return EditujMapu(prazdnaMapa);
        }
    }
}
