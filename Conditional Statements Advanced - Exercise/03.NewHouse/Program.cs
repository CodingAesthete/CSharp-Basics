using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeOfFlowers == "Roses")
            {
                price = 5 * countFlowers;
                if (countFlowers > 80)
                {
                    price = 0.9 * price;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.80 * countFlowers;
                if (countFlowers > 90)
                {
                    price = 0.85 * price;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.80 * countFlowers;
                if (countFlowers > 80)
                {
                    price = 0.80 * price;
                }
            }
            else if(typeOfFlowers== "Narcissus")
            {
                price = 3 * countFlowers;
                if (countFlowers < 120)
                {
                    price = 1.15 * price;
                }
            }
            else if(typeOfFlowers== "Gladiolus")
            {
                price = 2.50 * countFlowers;
                if(countFlowers < 80)
                {
                    price = 1.20 * price;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeOfFlowers} and {(budget-price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price-budget):f2} leva more.");
            }
        }
    }
}
