using System;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int e = 1; e <= 10; e++)
                {
                    Console.WriteLine($"{i} * {e} = {i*e}");
                }
            }
        }
    }
}
