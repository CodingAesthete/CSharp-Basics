using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area=double.Parse(Console.ReadLine());
            double priceWithoutDiscount = 7.61 * area;
            double discount = 0.18 * priceWithoutDiscount;
            double priceAfterDiscount = priceWithoutDiscount - discount;
            Console.WriteLine($"The final price is: {priceAfterDiscount} lv");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
