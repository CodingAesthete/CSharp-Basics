using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double income = 0;

            if (projectionType == "Premiere")
            {
                income = 12.00 * seats;
            }
            else if (projectionType == "Normal")
            {
                income = 7.50 * seats;
            }
            else if (projectionType == "Discount")
            {
                income = 5.00 * seats;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
