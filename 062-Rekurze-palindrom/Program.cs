using System;

namespace _062_Rekurze_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string veta1 = "jelenovi pivo nelej";
            string veta2 = "kuna nese nanuk";
            string veta3 = "kuna neste nanuk";

            Console.WriteLine(JePalindrom(veta1));
            Console.WriteLine(JePalindrom(veta2));
            Console.WriteLine(JePalindrom(veta3));
        }

        static bool JePalindrom(string retezec)
        {
            retezec = retezec.Trim();

            if (retezec.Length < 2)
                return true;

            if (retezec[0] != retezec[retezec.Length - 1])
                return false;

            string podretezec = retezec.Substring(1, retezec.Length - 2);
            return JePalindrom(podretezec);
        }
    }
}
