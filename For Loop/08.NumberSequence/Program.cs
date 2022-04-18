using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < numsCount; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }

                if (currNum < minNum)
                {
                    minNum = currNum;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
