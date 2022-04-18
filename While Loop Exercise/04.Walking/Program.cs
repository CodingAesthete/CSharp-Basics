using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int steps = 0;

            while((input=Console.ReadLine())!="Going home")
            {
                steps += int.Parse(input);
                if (steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps-10000} steps over the goal!");
                    return;
                }
            }

            int lastInput = int.Parse(Console.ReadLine());
            steps += lastInput;

            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
                return;
            }

            Console.WriteLine($"{10000-steps} more steps to reach goal.");
        }
    }
}
