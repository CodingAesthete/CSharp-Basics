using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currNum = 1;

            while (currNum <= input)
            {
                Console.WriteLine(currNum);
                currNum = 2 * currNum + 1;
            }
        }
    }
}
