using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination;

            while ((destination = Console.ReadLine()) != "End")
            {
                string inputMoney =Console.ReadLine();

                if (inputMoney == "End")
                {
                    break;
                }

                double neededMoney = double.Parse(inputMoney);
                string input = Console.ReadLine();
                double sparedMoney = 0;

                while (input!="End")
                {
                    sparedMoney += double.Parse(input);
                    
                    if (sparedMoney >= neededMoney)
                    {
                        break;
                    }
                    input = Console.ReadLine();
                }

                if (input == "End")
                {
                    break;
                }

                if ( sparedMoney >= neededMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}
