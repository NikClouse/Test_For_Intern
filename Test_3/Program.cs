using System;

namespace Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 7, 2, 3, 9, 4, 7, 1, 3, 6, 8, 3, 7, 8, 3 };
            int minSum = array[0] + array[1];
            int index = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + array[i + 1] < minSum)
                {
                    minSum = array[i] + array[i + 1];
                    index = i;
                }
            }

            Console.WriteLine($"Два соседних элемента с минимальной суммой: {array[index]} и {array[index + 1]}");

        }
    }
}
