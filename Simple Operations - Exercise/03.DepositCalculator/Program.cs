using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            double finalAmount = depositedAmount + (depositTerm * ((depositedAmount * annualInterestRate/100) / 12));
            Console.WriteLine(finalAmount);
        }
    }
}
