using System;

namespace _4._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MethodAnswer(str);
            IterativeAnswer(str);
        }
        static void MethodAnswer(string s)
        {
            string upgrated = s.Replace("And ", "& ", StringComparison.OrdinalIgnoreCase).Replace("Or ", "| ", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(upgrated);
        }
        static void IterativeAnswer (string s)
        {
            string upgratedstr = string.Empty;
            char[] array = s.ToCharArray();
            for (int i=0; i<array.Length; i++)
            {
                if ((Char.IsWhiteSpace(array[i]))&&((array[i+1] == 'o') || (array[i+1] == 'O')) && ((array[i + 2] == 'r') || (array[i + 2] == 'R'))&&(Char.IsWhiteSpace(array[i+3])))
                {
                    array[i+1] = ' ';
                    upgratedstr += array[i+1];
                    array[i + 2] = '|';
                    upgratedstr += array[i + 2];
                    i+=2;
                }
                else if ((Char.IsWhiteSpace(array[i]))&&((array[i+1] == 'a') || (array[i+1] == 'A')) && ((array[i + 2] == 'n') || (array[i + 2] == 'N')) && ((array[i + 3] == 'd') || (array[i + 3] == 'D')))
                {
                    array[i+1] = ' ';
                    upgratedstr += array[i+1];
                    array[i + 2] = '&';
                    upgratedstr += array[i + 2];
                    i += 3;
                }
                else
                {
                    upgratedstr += array[i];
                }
            }
            Console.WriteLine(upgratedstr);
        }
    }
}
