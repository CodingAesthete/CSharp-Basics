using System;

namespace _05.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodPackets = int.Parse(Console.ReadLine());
            int catFoodPackets = int.Parse(Console.ReadLine());
            double priceCatFood = 4;
            double priceDogFood = 2.50;
            double bill = catFoodPackets * priceCatFood + dogFoodPackets * priceDogFood;
            Console.WriteLine($"{bill} lv.");
        }
    }
}
