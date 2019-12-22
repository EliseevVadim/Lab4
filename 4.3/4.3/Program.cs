using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MethodAnswer(str);
            IterativeMethod(str);


        }
        static void MethodAnswer(string s)
        {
            string[] array = s.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = string.Empty;
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            string resultstring = string.Join(" ", array);
            Console.WriteLine(resultstring+".");
        }
        static void IterativeMethod (string s)
        {
            string newstr = string.Empty;
            char temp = '0';
            char[] mas = s.ToCharArray();
            int N = 0;
            int C = 0;
            for (int i=mas.Length-2; i>=0; i--)
            {
                newstr += mas[i];
            }
            newstr += ".";
            //Console.WriteLine(newstr);
            char[] array = newstr.ToCharArray();
            for (int i=0; i<array.Length; i++)
            {
               
                if (Char.IsWhiteSpace(array[i])||array[i]=='.')
                {
                    for (int j = C, k = i - 1; j < k; j++, k--)
                    {
                        temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }
                    C = i + 1;
                }
                
            }
            string res = new string(array);
            Console.WriteLine(res);
            

        }
        
    }
}
