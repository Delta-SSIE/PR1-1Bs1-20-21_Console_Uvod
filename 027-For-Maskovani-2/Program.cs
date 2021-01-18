using System;
using System.IO;
using System.Text;

namespace _027_For_Maskovani_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            /* nyni nacteme text z textoveho souboru, je soucasti projektu */
            string cestaVstup = @"vstup.txt";

            if (!File.Exists(cestaVstup))
            {
                Console.WriteLine("File not found");
                return;
            }

            string text = File.ReadAllText(cestaVstup);
            text = text.ToUpper();// zvetsim vse na velka pismena

            string zamaskovano = ""; //do tohoto retezce budu skladat zamaskovany text

            int krok = 7; //po kolika pismenech se bude preskakovat
            int offset = 4; //kolik pismen se predhodi pred prvni zamaskovana pismeno


            for (int i = 0; i < text.Length; i++) //posouvej pozici i pres cely text
            {
                if (text[i] < 65 || text[i] > 91) //nepismenne znaky budou zahozeny - vysledek bude bez mezer, carek atd.
                    continue;

                for (int j = 0; j < offset; j++) //vytvorim nahodne znaky na zacatek
                {
                    zamaskovano += (char)rnd.Next(65, 91); //toto je nahodne velke pismeno
                }
                zamaskovano += text[i];//pridam pismeno z puvodniho textu na pozici i
                for (int j = 0; j < krok - offset -1; j++)//vytvotim nahodne znaky abych doplnil periodu do celeho poctu "krok"
                {
                    zamaskovano += (char)rnd.Next(65, 91);
                }
            }

            int append = rnd.Next(0, krok); //pridam na konec nekolik nahodnych znaku, aby se nedala perioda zjistit z poctu znaku
            for (int j = 0; j < append; j++)
            {
                zamaskovano += (char)rnd.Next(65, 91);
            }

            /* zapisu do souboru */
            string cestaVystup = @"vystup.txt";
            File.WriteAllText(cestaVystup, zamaskovano, Encoding.UTF8);

            /*a jen tak pro radost i na obrazovku */
            Console.WriteLine(zamaskovano);
        }
    }
}
