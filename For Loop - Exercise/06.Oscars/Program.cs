using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());
            double target = 1250.5;

            for (int i = 0; i < evaluators; i++)
            {
                string evaluatorName = Console.ReadLine();
                double evaluatorPoints = double.Parse(Console.ReadLine());

                points += (evaluatorName.Length * evaluatorPoints) / 2;

                if (points >= target)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actorName} you need {(target - points):f1} more!");
        }
    }
}
