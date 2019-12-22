using System;
using System.Text.RegularExpressions;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            string[] mas = new string[10];
            int[] arr = new int[10];
            int ind = 0;
            int multiplyer = 600;
            int secondmultiplyer = 10;
            for (int i=0; i<array.Length; i++)
            {
                array[i] = Console.ReadLine();
                Regex regular = new Regex(@"[\[|\(]\s*0?\d{1,2}:\d{1,2}[\]|\)]");
                foreach (Match match in regular.Matches(array[i]))
                    mas[i] += match;               
            }
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i].Replace("(", string.Empty);
                mas[i] = mas[i].Replace(")", string.Empty);
                mas[i] = mas[i].Replace("[", string.Empty);
                mas[i] = mas[i].Replace("]", string.Empty);                                            
            }
            for (int i=0; i<mas.Length; i++)
            {
                char[] help = mas[i].ToCharArray();
                for (int j=0; j<help.Length; j++)
                {
                    if(help[j]==':')
                    {
                        ind = j;
                        break;
                    }
                }
                if (ind==2)
                {
                    for (int k = 0; k < ind; k++)
                    {
                        arr[i] += int.Parse(help[k].ToString()) * multiplyer;
                        multiplyer /= 10;
                    }
                    multiplyer = 600;
                    for (int q = ind + 1; q < help.Length; q++)
                    {
                        arr[i] += int.Parse(help[q].ToString()) * secondmultiplyer;
                        secondmultiplyer /= 10;
                    }
                    secondmultiplyer = 10;
                }
                else if (ind==1)
                {
                    multiplyer /= 10;
                    for (int k = 0; k < ind; k++)
                    {
                        arr[i] += int.Parse(help[k].ToString()) * multiplyer;
                        
                    }
                    multiplyer = 600;
                    for (int q = ind + 1; q < help.Length; q++)
                    {
                        arr[i] += int.Parse(help[q].ToString()) * secondmultiplyer;
                        secondmultiplyer /= 10;
                    }
                    secondmultiplyer = 10;
                }               
            }
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            string maxout = string.Empty;
            string minout = string.Empty;
            for (int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i]>max)
                {
                    max = arr[i];
                    maxout = array[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                    minout = array[i];
                }
            }
            int minutes = sum / 60;
            int seconds = sum % 60;
            int hours = 0;
            int difference = Math.Abs(arr[0] - arr[1]);
            string firstsongatdifference = array[0];
            string secondsongatdifference =array[1];
            for (int i=0; i<arr.Length-1; i++)
            {
                for (int j=0; j<arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) < difference&&(i!=j))
                    {
                        difference = Math.Abs(arr[i] - arr[j]);
                        firstsongatdifference = array[i];
                        secondsongatdifference = array[j];
                    }
                }              
            }
            Console.WriteLine("The longest song is: "+maxout);
            Console.WriteLine("The shortest song is: "+minout);
            if (minutes>=60)
            {
                while (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes -= 60;
                }
                Console.WriteLine($"Tracklist duration is: {hours}:{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"Tracklist duration is: {minutes}:{seconds}");
            }
            Console.WriteLine($"Two songs with the smallest difference in duration is: {firstsongatdifference} and {secondsongatdifference}");
        }
    }
}
