using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int totalPieces = length * width;
            string input;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int cakePieces = int.Parse(input);
                totalPieces -= cakePieces;

                if (totalPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    return;
                }
            }

            Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
}
