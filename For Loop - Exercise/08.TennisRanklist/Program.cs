using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int earnedPoints = 0;
            int wins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string phase = Console.ReadLine();

                if (phase == "W")
                {
                    wins++;
                    earnedPoints += 2000;
                    startPoints += 2000;
                }
                else if (phase == "F")
                {
                    earnedPoints += 1200;
                    startPoints += 1200;
                }
                else if (phase == "SF")
                {
                    earnedPoints += 720;
                    startPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(earnedPoints * 1.0 / tournaments)}");
            Console.WriteLine($"{((wins*1.0 / tournaments) * 100):f2}%");
        }
    }
}
