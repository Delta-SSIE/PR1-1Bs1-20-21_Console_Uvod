using System;

namespace _029_For_Caesarova_sifra
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Toto je tajna zprava.";
            string text = "UPUP KF UBKOB AQSBWB.";
            string zasifrovano = "";

            int posun = 5;

            text = text.ToUpper();

            //projdu retezec znak po znaku
            for (int i = 0; i < text.Length; i++)
            {
                int kodZnaku = text[i]; //ulozim jako int - tedy cislo, poradi v ASCII

                if (kodZnaku < 'A' || kodZnaku > 'Z')
                {
                    //znaky mimo abecedu
                    zasifrovano += text[i];
                }
                else
                {
                    //v abecede - budu posouvat
                    kodZnaku += posun;

                    //pri preteceni skoc na zacatek - abeceda ma 26 znaku
                    if (kodZnaku > 'Z')
                        kodZnaku -= 26;

                    //pro podteceni skoc na konec
                    else if (kodZnaku < 'A')
                        kodZnaku += 26;

                    char novyZnak = (char) kodZnaku;
                    zasifrovano += novyZnak;
                }
            }

            Console.WriteLine(zasifrovano);

        }
    }
}
