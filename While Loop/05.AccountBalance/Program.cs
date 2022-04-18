using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalSum = 0;

            while((input=Console.ReadLine())!="NoMoreMoney")
            {
                double currMoney = double.Parse(input);

                if (currMoney<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {currMoney:f2}");
                totalSum += currMoney;
            }

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
