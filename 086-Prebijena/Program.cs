using System;

namespace _086_Prebijena
{
    class Program
    {
        static void Main(string[] args)
        {
            //nová hra
            Hra hra = new Hra();

            //rozdej
            hra.Rozdej();
                      
            
            //dokud neni konec
            while(!hra.JeKonec)
            {
                //odehraj jedno kolo
                hra.Kolo();
            }

            //vypis vysledky
            hra.VypisVysledek();
        }
    }
}
