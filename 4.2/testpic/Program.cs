using System;

namespace testpic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MethodAnswer(str);
            Console.WriteLine();
            //IterativeAnswer(str);

        }
        static void MethodAnswer (string s)
        {
            string[] array = s.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            int num = 1;
            for (int i=0; i<array.Length; i++)
            {
                bool flag = true;
                if ((array[i].EndsWith(","))&&(array[i].EndsWith("."))) flag = false;
                if ((array[i] != "-")&&flag)
                {
                    array[i] += ("(" + num + ")");
                    num++;
                   
                }
                if (flag==false)
                {
                    array[i] = array[i].Remove(array[i].Length - 1);
                    array[i] += ("(" + num + "),");
                    num++;                    
                }

            }
            string newstr= string.Join(" ", array);
            Console.Write(newstr);
        }
        static void IterativeAnswer (string s)
        {
            string newstr = string.Empty;
            char[] mas = s.ToCharArray();
            int num = 1;
            for (int i=0; i<mas.Length; i++)
            {
                newstr += mas[i];
                if (((Char.IsLetter(mas[i]))&&(Char.IsWhiteSpace(mas[i+1])))|| ((Char.IsLetter(mas[i])) && (mas[i+1]=='.'))||((Char.IsLetter(mas[i])&&(mas[i+1]==','))))
                {
                    newstr += ("(" + num + ")");
                    num++;
                    
                }

            }
            Console.WriteLine(newstr);

        }
        

    }
}
