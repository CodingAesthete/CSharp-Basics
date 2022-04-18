using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            int newSum = 0;

            while (newSum < expectedSum)
            {
                newSum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(newSum);
        }
    }
}
