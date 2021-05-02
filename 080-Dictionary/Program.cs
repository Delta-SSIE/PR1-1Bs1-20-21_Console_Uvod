using System;
using System.Collections.Generic;


namespace _080_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> telefony = new Dictionary<string, int>();

            telefony.Add("Jarda", 777152784);
            telefony.Add("Miluška", 605778847);
            telefony.Add("Tonda", 562875485);

            //telefony.Clear();

            //if (!telefony.ContainsKey("Jarda"))
            //{ 
            //    telefony.Add("Jarda", 777152783);
            //}

            
            telefony.TryAdd("Jarda", 777152783);
            

            telefony["Toník"] = 604852521;

            Console.WriteLine(telefony.Count);
            
            if (telefony.TryGetValue("Miluška", out int milosFon))
            {
                Console.WriteLine(milosFon);
            }
            //Console.WriteLine(telefony["Miloš"]);

            foreach (KeyValuePair<string, int> polozka in telefony)
            {
                Console.WriteLine($"{polozka.Key}: {polozka.Value}");
            }



        }


    }
}
