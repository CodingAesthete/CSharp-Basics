using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currNum = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;

                for (int e = 0; e < currNum.Length; e++)
                {
                    if (e % 2 == 0)
                    {
                        sumOdd += int.Parse(currNum[e].ToString());
                    }
                    else
                    {
                        sumEven += int.Parse(currNum[e].ToString());
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
