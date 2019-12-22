using System;
using System.Collections.Generic;

namespace _4._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите шифр:\n1)Шифр простой одинарной перестановки\n2)Книжный шифр\n3)Шифр Виженера");
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "1":
                    CC();
                    Console.WriteLine("Введите текст");
                    string str = Console.ReadLine();
                    CC();
                    Console.WriteLine("Строка, зашифрованная посредством шифра простой одинарной перестановки: ");
                    SimpleSingleSwapCipher(str);
                    break;
                case "2":
                    CC();
                    Console.WriteLine("Введите текст");
                    string str2 = Console.ReadLine();
                    CC();
                    Console.WriteLine("Строка, зашифрованная посредством книжного шифра: ");
                    BookCipher(str2);
                    break;
                case "3":
                    CC();
                    Console.WriteLine("Введите текст");
                    string str3 = Console.ReadLine();
                    CC();
                    VigenereCipher(str3);
                    break;
                default: Console.WriteLine("До свидания!"); break;
            }           
        }
        static void CC()
        {
            Console.Clear();
        }
        static void SimpleSingleSwapCipher (string s)
        {
            string newstr1 = s.Replace(" ", string.Empty);
            newstr1 = newstr1.ToLower();
            char[] array = newstr1.ToCharArray();
            char temp = '0';
            for (int i=0; i<array.Length/2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            string result = new string(array);
            Console.WriteLine(result);
        }
        static void BookCipher (string s)
        {
            string key = "съешь ещё этих мягких французских булок, да выпей же чаю";
            string newstr = s.ToLower();
            newstr = newstr.Replace(" ", string.Empty);
            char[] mas = newstr.ToCharArray();
            Random rand = new Random();
            List<int> test = new List<int>();

            for (int i=0; i<mas.Length; i++)
            {
                int N = rand.Next(0, 2);
                switch (N)
                {
                    case 0:
                        test.Add(key.IndexOf(mas[i]));
                        Console.Write(test[i]);
                        break;
                    default:
                        test.Add(key.LastIndexOf(mas[i]));
                        Console.Write(test[i]);
                        break;
                }
            }                        
        }
        static void VigenereCipher (string s)
        {
            char[] alphabete = new char [] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            s = s.ToLower();
            Console.WriteLine("Ведите ключ");
            string key = Console.ReadLine();
            string output = string.Empty;
            int keypos = 0;
            key = key.ToLower();
            char[] array = s.ToCharArray();
            char[] keyarr = key.ToCharArray();
            int N = alphabete.Length;
            for (int i=0; i<array.Length; i++)
            {
                int pos = (s.IndexOf(array[i]) + key.IndexOf(keyarr[keypos])) % N;
                output += alphabete[pos];
                keypos++;
                if (keypos + 1 == keyarr.Length)
                {
                    keypos = 0;
                }
            }
            Console.WriteLine(output);           
        }
    }
}
