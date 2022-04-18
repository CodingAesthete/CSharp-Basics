using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i <= sum; i++)
            {
                for (int e = 0; e <= sum; e++)
                {
                    for (int a = 0; a <= sum; a++)
                    {
                        if (i + e + a == sum)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
