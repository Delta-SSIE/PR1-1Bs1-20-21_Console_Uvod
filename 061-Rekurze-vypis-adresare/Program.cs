using System;
using System.IO;

namespace _061_Rekurze_vypis_adresare
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp";

            if (Directory.Exists(path))
            {
                PrintPath(path);
            }
            else
            {
                Console.WriteLine("Path is now a valid directory.");
            }
        }

        static void PrintPath(string path, int depth = 0)
        {
            Console.WriteLine("".PadRight(depth * 2) + path);
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    PrintPath(file, depth + 1);
                }
                //for (int i = 0;  i < files.Length;  i++)
                //{
                //    PrintPath(files[i], depth + 1);
                //}
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    PrintPath(dir, depth + 1);
                }
                //for (int i = 0; i < dirs.Length; i++)
                //{
                //    PrintPath(dirs[i], depth + 1);
                //}
            }
        }
    }
}
