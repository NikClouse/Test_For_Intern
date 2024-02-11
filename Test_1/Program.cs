using System;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double rate;

            if (deposit < 100)
            {
                rate = 0.05;
            }
            else if (deposit <= 200)
            {
                rate = 0.07;
            }
            else
            {
                rate = 0.1;
            }

            double total = deposit + deposit * rate;
            Console.WriteLine($"Сумма вклада с начисленными процентами: {total}");
        }
    }
}
