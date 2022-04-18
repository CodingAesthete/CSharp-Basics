using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sumPrime = 0;
            int sumNonPrime = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int currNum = int.Parse(input);

                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if(currNum%2==0 || currNum%3==0 || currNum%5==0 || currNum % 7 == 0)
                {
                    if(currNum==2 || currNum==3 || currNum==5 || currNum == 7)
                    {
                        sumPrime += currNum;
                    }
                    else
                    {
                        sumNonPrime += currNum;
                    }
                }
                else
                {
                    sumPrime += currNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
