using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minNum = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currNum = int.Parse(input);

                if (currNum < minNum)
                {
                    minNum = currNum;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
