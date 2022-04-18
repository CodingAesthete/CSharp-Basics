using System;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus= int.Parse(Console.ReadLine());
            double deliveryPrice = 2.50;
            double priceMenus = 10.35 * chickenMenus + 12.40 * fishMenus + 8.15 * vegetarianMenus;
            double dessert = 0.2 * priceMenus;
            double amountDue = priceMenus + dessert + deliveryPrice;
            Console.WriteLine(amountDue);
        }
    }
}
