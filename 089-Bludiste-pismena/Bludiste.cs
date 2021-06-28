using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _089_Bludiste_pismena
{
    class Bludiste
    {
        private char start;
        private char cil;
        private Dictionary<char, char[]> rozcesti;

        public void Nacti(string filename)
        {

            //načítej řádky
            using (StreamReader file = new StreamReader(filename))
            {
                //1 řádek = start
                start = file.ReadLine().Trim()[0];

                //2 řádek = cíl
                cil = file.ReadLine().Trim()[0];

                rozcesti = new Dictionary<char, char[]>();

                string line;
                while ( (line = file.ReadLine()) != null )
                {
                    //prázdné řádky se přeskakují
                    line = line.Trim();
                    if (line.Length < 1)
                        continue;

                    //každý další výchozí uzel : seznam cest
                    // J: N,F, P

                    string[] kousky = line.Split(':');
                    if (kousky.Length != 2)
                        continue;

                    char kdeJsem = kousky[0].Trim()[0];


                    List<char> kamMuzu = new List<char>();
                    foreach (string soused in kousky[1].Split(','))
                    {
                        kamMuzu.Add(soused.Trim()[0]);
                    }

                    rozcesti[kdeJsem] = kamMuzu.ToArray();

                }

                //foreach (var item in rozcesti)
                //{
                //    Console.WriteLine(item.Key + ":" + String.Join('|', item.Value));
                //}
            }
        }

        public char[] Projdi()
        {
            //fronta rpo rozcesti, ktera mam navstivit
            Queue<char> kamJit = new Queue<char>();

            //ke kazdemu rozcesti si napis vzdalenost od startu
            Dictionary<char, int> vzdalenosti = new Dictionary<char, int>();

            kamJit.Enqueue(start);
            vzdalenosti[start] = 0;

            //prochazej bludiste, dokud jsou volna rozcesti a nejsi v cili
            while (kamJit.Count > 0)
            {
                //vezmeme dalsi rozcesti
                char kdeJsem = kamJit.Dequeue();

                if (kdeJsem == cil)
                    break;

                int krok = vzdalenosti[kdeJsem];
                krok++;

                foreach(char soused in rozcesti[kdeJsem])
                {
                    // N : F, H, P

                    //pokud uz jsem zde byl, preskocim
                    if (vzdalenosti.ContainsKey(soused))
                        continue;

                    vzdalenosti[soused] = krok;
                    kamJit.Enqueue(soused);
                }
            }

            //foreach (var item in vzdalenosti)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);
            //}

            //hledam cestu tak, že začnu v cíli a hledám sousedy s nižším číslem

            List<char> cesta = new List<char>();
            char pozice = cil;
            while (pozice != start)
            {
                cesta.Add(pozice);
                foreach(char soused in rozcesti[pozice])
                {
                    if (vzdalenosti.ContainsKey(soused) && vzdalenosti[soused] < vzdalenosti[pozice])
                    {
                        pozice = soused;
                        continue;
                    }
                }
            }
            cesta.Add(start);

            cesta.Reverse();

            return cesta.ToArray();
        }
    }
}
