using System;
using System.Text.RegularExpressions;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            RegularMethod(str);
            ArrayMethod(str);
        }
        static void RegularMethod (string s)
        {
            Regex regular = new Regex(@"\b[A-Z][a-z]*\d{2}\b");
            foreach (Match match in regular.Matches(s))
                Console.WriteLine(match);
        }
        static void ArrayMethod (string s)
        {
            string[] arr = s.Split(new char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i=0; i<arr.Length; i++)
            {
                char[] mas = arr[i].ToCharArray();
                if (Char.IsUpper(mas[0]) && Char.IsDigit(mas[mas.Length - 1]) && Char.IsDigit(mas[mas.Length - 2]))
                {
                    string newstr = new string(mas);
                    Console.WriteLine(newstr);
                }
                    
            }
        }
    }
}
