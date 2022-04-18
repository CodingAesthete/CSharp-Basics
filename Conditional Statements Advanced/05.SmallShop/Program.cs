using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50 * quantity;
                }
                else if (product == "water")
                {
                    price = 0.80 * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.20 * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.45 * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.60 * quantity;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40 * quantity;
                }
                else if (product == "water")
                {
                    price = 0.70 * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.15 * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.30 * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.50 * quantity;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45 * quantity;
                }
                else if (product == "water")
                {
                    price = 0.70 * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.10 * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.35 * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.55 * quantity;
                }
            }
            Console.WriteLine(price);
        }
    }
}
