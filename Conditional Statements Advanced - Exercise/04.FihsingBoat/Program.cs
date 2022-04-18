using System;

namespace _04.FihsingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer")
            {
                price = 4200;
            }
            else if (season == "Autumn")
            {
                price = 4200;
            }
            else
            {
                price = 2600;
            }

            if (fishers <= 6)
            {
                price = 0.9 * price;
            }
            else if(fishers>=7 && fishers <= 11)
            {
                price = 0.85 * price;
            }
            else if (fishers >= 12)
            {
                price = 0.75 * price;
            }

            if (fishers%2==0 && season != "Autumn")
            {
                price = 0.95 * price;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget-price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price-budget):f2} leva.");
            }
        }
    }
}
