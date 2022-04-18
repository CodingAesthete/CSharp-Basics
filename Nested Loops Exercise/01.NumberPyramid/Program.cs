using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int end = 0;

            for (int i = 1; i <= input; i++)
            {
                end++;
                for (int e = 1; e <= end; e++)
                {
                    if (e != 1)
                    {
                        i++;
                    }
                    Console.Write($"{i} ");
                    if (i == input)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
