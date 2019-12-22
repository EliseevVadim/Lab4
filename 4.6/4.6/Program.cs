using System;
using System.Text.RegularExpressions;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newstr = string.Empty;
             Regex regular = new Regex(@"\s*[\-]?\d+\s*[\+|\-]?\s*\d+\s*=\s*-?\d+");
            foreach (Match match in regular.Matches(str))
            {                
                newstr+= (match);               
            }
            //newstr = newstr.Replace(" ", string.Empty);
            Console.WriteLine(newstr);
            string[] array = newstr.Split(new char[] { '+', '=' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {

                mas[i] = int.Parse(array[i]);

                Console.WriteLine("int mas{0} is {1}", i, mas[i]);
            }




        }
    }
}
