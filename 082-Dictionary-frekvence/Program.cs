using System;
using System.Collections.Generic;
using System.Linq;


namespace _082_Dictionary_frekvence
{
    class Program
    {
        static void Main(string[] args)
        {
            // načíst data
            string text = System.IO.File.ReadAllText(@"babicka.txt");

            // najít slova
            string[] words = GetWords(text);

            //Console.WriteLine(String.Join(", ", words));

            // u každého slova si "udělat čárku"
            Dictionary<string, int> counts = WordCounts(words);

            // vypsat výsledky
            //foreach (var pair in counts)
            //{
            //    Console.WriteLine($"{pair.Key}: {pair.Value}");
            //}

            //nadstavba - setřídění
            var sorted = counts.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }


        }

        static string[] GetWords(string text)
        {
            List<string> words = new List<string>();

            string word = "";

            foreach (char chr in text.ToLower())
            {
                if (Char.IsLetter(chr))
                    word += chr;
                else if (word.Length > 0)
                {
                    words.Add(word);
                    word = "";
                }
            }

            return words.ToArray();
        }

        static Dictionary<string, int> WordCounts (string[] words)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                //když tam slovo už je
                if (counts.ContainsKey(word))
                {
                    //přidej 1 k počtu
                    counts[word]++;
                }
                //jinak slovo zaveď 
                else
                {
                    //s počtem 1
                    counts[word] = 1;
                }
            }

            return counts;
        }
    }
}
