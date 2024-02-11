using System;
using System.Text.RegularExpressions;

namespace Test_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Решение с использованием регулярных выражений
            string pattern = @"(\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b)|(\b(https?://)?[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b)";
            string result = Regex.Replace(input, pattern, m => new String('*', m.Length));
            Console.WriteLine("Результат с использованием регулярных выражений: " + result);

            // Решение без использования регулярных выражений
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("@") || words[i].Contains(".com"))
                {
                    words[i] = new String('*', words[i].Length);
                }
            }
            result = String.Join(" ", words);
            Console.WriteLine("Результат без использования регулярных выражений: " + result);
        }
    }
}
