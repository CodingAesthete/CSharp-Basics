using System;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int e = 0; e < 60; e++)
                {
                    Console.WriteLine($"{i}:{e}");
                }
            }
        }
    }
}
