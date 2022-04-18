using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            string trial = Console.ReadLine();
            while (trial != pass)
            {
                trial = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
