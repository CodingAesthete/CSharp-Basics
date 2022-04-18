using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;

            if (roomType == "room for one person")
            {
                daysOfStay -= 1;
                price = daysOfStay * 18.00;
            }
            else if (roomType == "apartment")
            {
                price = (daysOfStay - 1) * 25.00;

                if (daysOfStay < 10)
                {
                    price = 0.70 * price;
                }
                else if (daysOfStay >= 10 && daysOfStay <= 15)
                {
                    price = 0.65 * price;
                }
                else
                {
                    price = 0.50 * price;
                }
            }
            else if (roomType == "president apartment")
            {
                price = (daysOfStay - 1) * 35.00;

                if (daysOfStay < 10)
                {
                    price = 0.90 * price;
                }
                else if (daysOfStay >= 10 && daysOfStay <= 15)
                {
                    price = 0.85 * price;
                }
                else
                {
                    price = 0.80 * price;
                }
            }

            if (rating == "positive")
            {
                price = 1.25 * price;
            }
            else
            {
                price = 0.90 * price;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
