using System;
using System.Collections.Generic;

namespace _085_Find_file
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFileQueue(@"C:\Temp", "style.css");
            Console.WriteLine();
            Console.WriteLine();
            FindFileStack(@"C:\Temp", "style.css");
        }
        
        static string[] FindFileQueue(string path, string filename)
        {
            Queue<string> dirsToSearch = new Queue<string>(); //adresáře k prohledání
            dirsToSearch.Enqueue(path);

            List<string> found = new List<string>();

            while (dirsToSearch.Count > 0) //dokud je co prohledávat, pracuj
            {
                string currrentDir = dirsToSearch.Dequeue(); //vyjmi první prvek z fronty
                Console.WriteLine(currrentDir);

                string[] files = System.IO.Directory.GetFiles(currrentDir); //vezmi pole všech souborů v něm

                foreach (string file in  files)
                {
                    string currentFileName = System.IO.Path.GetFileName(file); //jen jmeno souboru bez cesty
                    if (currentFileName == filename)
                    {
                        found.Add(file);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(file);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                string[] subdirs = System.IO.Directory.GetDirectories(currrentDir); //vezmi pole všech podadresářů
                foreach (string dir in subdirs)
                {
                    dirsToSearch.Enqueue(dir);
                }
            }

            return found.ToArray();
        }        
        static string[] FindFileStack(string path, string filename)
        {
            Stack<string> dirsToSearch = new Stack<string>(); //adresáře k prohledání
            dirsToSearch.Push(path);

            List<string> found = new List<string>();

            while (dirsToSearch.Count > 0) //dokud je co prohledávat, pracuj
            {
                string currrentDir = dirsToSearch.Pop(); //vyjmi první prvek z fronty
                Console.WriteLine(currrentDir);

                string[] files = System.IO.Directory.GetFiles(currrentDir); //vezmi pole všech souborů v něm

                foreach (string file in files)
                {
                    string currentFileName = System.IO.Path.GetFileName(file); //jen jmeno souboru bez cesty
                    if (currentFileName == filename)
                    {
                        found.Add(file);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(file);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                string[] subdirs = System.IO.Directory.GetDirectories(currrentDir); //vezmi pole všech podadresářů
                foreach (string dir in subdirs)
                {
                    dirsToSearch.Push(dir);
                }
            }

            return found.ToArray();
        }
    }
}
