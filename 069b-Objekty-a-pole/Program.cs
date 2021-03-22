using System;

namespace _069b_Objekty_a_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Postava bobik = new Postava();
            //bobik.Jmeno = "Bobík",
            //bobik.Rasa = Rasa.Prase,
            //bobik.OblibenaJidla = new string[] { "Tlačenka", "Guláš", "Vajíčka" }

            //Console.WriteLine(bobik.OblibenaJidla[0]);

            //foreach (string jidlo in bobik.OblibenaJidla)
            //    Console.WriteLine(jidlo);

            //Console.WriteLine(bobik.SeznamJidel());


            //Postava fifinka = new Postava
            //{
            //    Jmeno = "Fifinka",
            //    Rasa = Rasa.Pes,
            //    OblibenaJidla = new string[] { "Salát" }
            //};

            //Postava pinda = new Postava() {
            //    Jmeno = "Pinďa",
            //    Rasa = Rasa.Zajíc,
            //    OblibenaJidla = new string[] { "Salát", "Mrkev", "Rohlík" }
            //};

            //Postava myspulin = new Postava
            //{
            //    Jmeno = "Myšpulín",
            //    Rasa = Rasa.Kočka,
            //    OblibenaJidla = new string[] { "Konzerva", "Párek", "Kuře", "Pilulky" }
            //};

            //Postava[] ctyrlistek = new Postava[3];
            //ctyrlistek[0] = bobik;
            //ctyrlistek[1] = fifinka;
            //ctyrlistek[2] = pinda;

            //Postava[] ctyrlistek = new Postava[] { bobik, fifinka, pinda, myspulin };

            Postava[] ctyrlistek = new Postava[] {

                new Postava
                {
                    Jmeno = "Bobík",
                    Rasa = Rasa.Prase,
                    OblibenaJidla = new string[] { "Tlačenka", "Guláš", "Vajíčka" }
                },

                new Postava
                {
                    Jmeno = "Fifinka",
                    Rasa = Rasa.Pes,
                    OblibenaJidla = new string[] { "Salát" }
                },

                new Postava
                {
                    Jmeno = "Pinďa",
                    Rasa = Rasa.Zajíc,
                    OblibenaJidla = new string[] { "Salát", "Mrkev", "Rohlík" }
                },

                new Postava
                {
                    Jmeno = "Myšpulín",
                    Rasa = Rasa.Kočka,
                    OblibenaJidla = new string[] { "Konzerva", "Párek", "Kuře", "Pilulky" }
                }
            };

            for (int i = 0; i < ctyrlistek.Length; i++)
            {
                Postava p = ctyrlistek[i];
                Console.WriteLine($"{p.Jmeno}: {p.SeznamJidel()}");
            }

            foreach (Postava p in ctyrlistek)
            {
                Console.WriteLine($"{p.Jmeno}: {p.SeznamJidel()}");
            }



        }
    }
}
