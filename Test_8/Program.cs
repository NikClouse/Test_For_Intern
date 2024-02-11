using System;
using System.Linq;

namespace Test_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            int totalPlusMinus = input.Count(c => c == '+' || c == '-');
            int followedByZero = input.Where((c, i) => (c == '+' || c == '-') && i < input.Length - 1 && input[i + 1] == '0').Count();

            Console.WriteLine($"Общее количество символов '+' и '-': {totalPlusMinus}");
            Console.WriteLine($"Количество символов '+' и '-', после которых следует цифра ноль: {followedByZero}");
        }
    }
}
