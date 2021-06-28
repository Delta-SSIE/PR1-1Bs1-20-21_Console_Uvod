using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _083_Sifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"tajna-zprava.txt");

            Dictionary<char, char> code = new Dictionary<char, char>();
            code['a'] = 'x';
            code['b'] = 'j';
            code['c'] = 'z';
            code['d'] = 'o';
            code['e'] = 'g';
            code['f'] = 'd';
            code['g'] = 'p';
            code['h'] = 'u';
            code['i'] = 'h';
            code['j'] = 'w';
            code['k'] = 'm';
            code['l'] = 'i';
            code['m'] = 'a';
            code['n'] = 'l';
            code['o'] = 's';
            code['p'] = 'v';
            code['q'] = 'r';
            code['r'] = 'c';
            code['s'] = 't';
            code['t'] = 'k';
            code['u'] = 'y';
            code['v'] = 'n';
            code['w'] = 'q';
            code['x'] = 'b';
            code['y'] = 'f';
            code['z'] = 'e';

            string output = "";

            foreach (char chr in text)
            {
                char c = chr;
                if (Char.IsLetter(c))
                {
                    bool isUpper = Char.ToUpper(c) == c;
                    if (isUpper)
                        c = Char.ToLower(c);
                    c = code[c];
                    if (isUpper)
                        c = Char.ToUpper(c);

                }

                output += c;
            }

            string outPath = @"output.txt";
            File.WriteAllText(outPath, output, Encoding.UTF8);
        }
    }
}
