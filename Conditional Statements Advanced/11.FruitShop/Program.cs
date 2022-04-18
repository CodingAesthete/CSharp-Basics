using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    price = 2.50 * quantity;
                }
                else if (product == "apple")
                {
                    price = 1.20 * quantity;
                }
                else if (product == "orange")
                {
                    price = 0.85 * quantity;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45 * quantity;
                }
                else if (product == "kiwi")
                {
                    price = 2.70 * quantity;
                }
                else if (product == "pineapple")
                {
                    price = 5.50 * quantity;
                }
                else if (product == "grapes")
                {
                    price = 3.85 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    price = 2.70 * quantity;
                }
                else if (product == "apple")
                {
                    price = 1.25 * quantity;
                }
                else if (product == "orange")
                {
                    price = 0.90 * quantity;
                }
                else if (product == "grapefruit")
                {
                    price = 1.60 * quantity;
                }
                else if (product == "kiwi")
                {
                    price = 3.00 * quantity;
                }
                else if (product == "pineapple")
                {
                    price = 5.60 * quantity;
                }
                else if (product == "grapes")
                {
                    price = 4.20 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else{
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
