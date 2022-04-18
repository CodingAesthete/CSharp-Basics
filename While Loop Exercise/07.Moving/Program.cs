using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;
            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                int currBoxes = int.Parse(input);
                volume -= currBoxes;

                if (volume < 0)
                {
                    break;
                }
            }

            if (volume < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
        }
    }
}
