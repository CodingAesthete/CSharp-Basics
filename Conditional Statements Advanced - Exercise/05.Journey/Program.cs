using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeofJourney = "";

            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    typeofJourney = "Camp";
                    price = 0.3 * budget;
                }
                else if (season == "winter")
                {
                    typeofJourney = "Hotel";
                    price = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    typeofJourney = "Camp";
                    price = 0.4 * budget;
                }
                else if (season == "winter")
                {
                    typeofJourney = "Hotel";
                    price = 0.8 * budget;
                }
            }
            else if (budget >= 1000)
            {
                destination = "Europe";
                typeofJourney = "Hotel";

                price = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeofJourney} - {price:f2}");
        }
    }
}
