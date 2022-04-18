using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            int numsUnder200 = 0;
            int nums200to399 = 0;
            int nums400to599 = 0;
            int nums600to799 = 0;
            int numsOver800 = 0;

            for (int i = 0; i < numsCount; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum < 200)
                {
                    numsUnder200++;
                }
                else if (currNum >= 200 && currNum <= 399)
                {
                    nums200to399++;
                }
                else if (currNum >= 400 && currNum <= 599)
                {
                    nums400to599++;
                }
                else if (currNum >= 600 && currNum <= 799)
                {
                    nums600to799++;
                }
                else
                {
                    numsOver800++;
                }
            }

            Console.WriteLine($"{(numsUnder200 * 1.0 / numsCount * 100):f2}%");
            Console.WriteLine($"{(nums200to399 * 1.0 / numsCount * 100):f2}%");
            Console.WriteLine($"{(nums400to599 * 1.0 / numsCount * 100):f2}%");
            Console.WriteLine($"{(nums600to799 * 1.0 / numsCount * 100):f2}%");
            Console.WriteLine($"{(numsOver800 * 1.0 / numsCount * 100):f2}%");
        }
    }
}
