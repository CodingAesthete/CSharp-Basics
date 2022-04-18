using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int stages = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int level = 0;

            for (int i = stages; i >= 1; i--)
            {
                level++;
                if (level == 1)
                {
                    for (int e = 0; e < rooms; e++)
                    {
                        Console.Write($"L{i}{e} ");
                    }
                    Console.WriteLine();
                    continue;
                }
                for (int e = 0; e < rooms; e++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write($"A{i}{e} ");
                    }
                    else
                    {
                        Console.Write($"O{i}{e} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
