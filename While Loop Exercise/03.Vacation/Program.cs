using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double myMoney = double.Parse(Console.ReadLine());
            int spendRow = 0;
            int daysPassed = 0;

            while (spendRow < 5)
            {
                daysPassed++;
                string typeOfAction = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (typeOfAction == "spend")
                {
                    spendRow++;
                    myMoney -= amount;
                    if (myMoney < 0)
                    {
                        myMoney = 0;
                    }
                }
                else
                {
                    spendRow = 0;
                    myMoney += amount;

                    if (myMoney >= excursionPrice)
                    {
                        Console.WriteLine($"You saved the money for {daysPassed} days.");
                        return;
                    }
                }
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysPassed);
        }
    }
}
