using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double moneyFromSell = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town == "Sofia")
            {
                if (moneyFromSell >= 0 && moneyFromSell <= 500)
                {
                    commission = 0.05 * moneyFromSell;
                }
                else if (moneyFromSell > 500 && moneyFromSell <= 1000)
                {
                    commission = 0.07 * moneyFromSell;
                }
                else if (moneyFromSell > 1000 && moneyFromSell <= 10000)
                {
                    commission = 0.08 * moneyFromSell;
                }
                else if (moneyFromSell > 10000)
                {
                    commission = 0.12 * moneyFromSell;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (town == "Varna")
            {
                if (moneyFromSell >= 0 && moneyFromSell <= 500)
                {
                    commission = 0.045 * moneyFromSell;
                }
                else if (moneyFromSell > 500 && moneyFromSell <= 1000)
                {
                    commission = 0.075 * moneyFromSell;
                }
                else if (moneyFromSell > 1000 && moneyFromSell <= 10000)
                {
                    commission = 0.10 * moneyFromSell;
                }
                else if (moneyFromSell > 10000)
                {
                    commission = 0.13 * moneyFromSell;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (town == "Plovdiv")
            {
                if (moneyFromSell >= 0 && moneyFromSell <= 500)
                {
                    commission = 0.055 * moneyFromSell;
                }
                else if (moneyFromSell > 500 && moneyFromSell <= 1000)
                {
                    commission = 0.08 * moneyFromSell;
                }
                else if (moneyFromSell > 1000 && moneyFromSell <= 10000)
                {
                    commission = 0.12 * moneyFromSell;
                }
                else if (moneyFromSell > 10000)
                {
                    commission = 0.145 * moneyFromSell;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine($"{commission:f2}");
        }
    }
}
