using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int maxNum = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currNum = int.Parse(input);

                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
