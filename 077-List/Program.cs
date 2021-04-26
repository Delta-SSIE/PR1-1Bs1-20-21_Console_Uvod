using System;
using System.Collections.Generic;

namespace _077_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> seznam = new List<string>();
            string[] zaklad = { "Vruty", "Hřebíky", "Vrtáky" };
            List<string> seznam = new List<string>(zaklad);

            Console.WriteLine($"Capacity : {seznam.Capacity}");
            seznam.Add("Pila");
            seznam.Add("Kladivo");
            Console.WriteLine($"Capacity : {seznam.Capacity}");

            Console.WriteLine(seznam.Count);

            seznam.Add("Sekera");

            Console.WriteLine(seznam.Count);

            Console.WriteLine(seznam[1]);
            seznam[1] = "Kolečko";
            Console.WriteLine(seznam[1]);

            PrintList(seznam);


            Console.WriteLine();
            //foreach (string item in seznam)
            //{
            //    Console.WriteLine(item);
            //}

            seznam.Remove("Kolečko");
            seznam.Remove("Kolečko");
            PrintList(seznam);

            seznam.RemoveAt(2);
            PrintList(seznam);

            seznam.Insert(1, "Hoblík");
            PrintList(seznam);

            seznam.Reverse();

            PrintList(seznam);
            //string[] s2 = seznam.ToArray();
            
        }

        static void PrintList(List<string> list)
        {
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} : {list[i]}");
            }
        }
    }
}
