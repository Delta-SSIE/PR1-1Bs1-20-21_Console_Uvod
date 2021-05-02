using System;
using System.Collections.Generic;

namespace _081_Morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> morse = new Dictionary<char, string>();
            morse['a'] = ".-";
            morse['b'] = "-...";
            morse['c'] = "-.-.";
            morse['d'] = "-..";
            morse['e'] = ".";
            morse['f'] = "..-.";
            morse['g'] = "--.";
            morse['h'] = "....";
            morse['i'] = "..";
            morse['j'] = ".---";
            morse['k'] = "-.-";
            morse['l'] = ".-..";
            morse['m'] = "--";
            morse['n'] = "-.";
            morse['o'] = "---";
            morse['p'] = ".--.";
            morse['q'] = "--.-";
            morse['r'] = ".-.";
            morse['s'] = "...";
            morse['t'] = "-";
            morse['u'] = "..-";
            morse['v'] = "...-";
            morse['w'] = ".--";
            morse['x'] = "-..-";
            morse['y'] = "-.--";
            morse['z'] = "--..";
            morse[' '] = "";

            string text = "Co bude dnes k obedu?";

            string kodovano = "";

            foreach (char chr in text.ToLower())
            {
                string znak;
                if (morse.TryGetValue(chr, out znak))
                    kodovano += znak + "/";
            }

            Console.WriteLine(kodovano);

        }
    }
}
