using System;
using System.Text.RegularExpressions;

namespace _4._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            RegularFinding(str);
        }
        static void RegularFinding (string s)
        {
            Regex regular = new Regex(@"\w+:\s*[int|short|byte]+\s*\[\d+\]");
            foreach (Match match in regular.Matches(s))
            Console.WriteLine(match);
        }
    }
}
