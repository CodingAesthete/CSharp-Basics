using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            double sum = 0;

            for (int i = 0; i < numsCount; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
                
                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }
            }

            if (sum / 2 == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-(sum-maxNum))}");
            }
        }
    }
}
