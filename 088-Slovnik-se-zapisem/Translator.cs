using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_Slovnik_se_zapisem
{
    class Translator
    {
        public Translator(string filename)
        {
            Filename = filename;
            Dictionary = new Dictionary<string, string>();
            ReadDictionary();
        }

        public Dictionary<String, String> Dictionary { get; set; }
        public string Filename { get; set; }

        public string GetWord(string message)
        {
            string word;
            do
            {
                Console.Write(message + ": ");
                word = Console.ReadLine().Trim();
            } 
            while (word.Length == 0);

            return word;
        }

        public void WriteDictionary()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Filename))
                {
                    foreach (var item in Dictionary)
                    {
                        file.WriteLine(item.Key + "," + item.Value);
                    }
                }
            }
            catch (Exception) 
            {
                Console.WriteLine("Nezdařil se zápis do souboru, aktuální data budou ztracena.");
            };
        }

        public void ReadDictionary()
        {
            Dictionary.Clear();
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(Filename))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] items = line.Split(',');
                        if (items.Length != 2)
                            continue;

                        //Dictionary[items[0]] = items[1];
                        Dictionary.Add(items[0], items[1]);
                    }
                }
            }
            catch (Exception) { };
        }
    }
}
