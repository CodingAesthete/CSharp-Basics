using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int numCombination = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                int sum = 0;
                for (int e = startInterval; e <= endInterval; e++)
                {
                    numCombination++;
                    sum = i + e;

                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{numCombination} ({i} + {e} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{numCombination} combinations - neither equals {magicNum}");
        }
    }
}
