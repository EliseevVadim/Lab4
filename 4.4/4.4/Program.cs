using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[7];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            FirstAnswer(array);
            SecondAnswer(array);
        }
        static void FirstAnswer (string [] mas)
        {
            for (int i=0; i<mas.Length; i++)
            {
                string[] arr = mas[i].Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j=0; j<arr.Length; j++)
                {
                    if (arr[j].EndsWith(".com", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write(mas[i]);
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
        static void SecondAnswer (string [] mas)
        {
            for (int i=0; i<mas.Length; i++)
            {
                bool flag = false;
                for (int j=0; j<mas[i].Length; j++)
                {
                    if ((mas[i][j]=='.')&&(mas[i][j+1]=='c')&&(mas[i][j+2]=='o')&&(mas[i][j+3]=='m')&&(mas[i][j+4]==' '))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
    }
}
