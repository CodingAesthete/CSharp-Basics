using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double firstSide = double.Parse(Console.ReadLine());
            double area=0;
            double secondSide=0;
            if (figureType=="square")
            {
                area = firstSide * firstSide;
            }
            else if (figureType == "circle")
            {
                area = Math.PI * firstSide * firstSide;
            }
            else if (figureType == "rectangle")
            {
                secondSide = double.Parse(Console.ReadLine());
                area = firstSide * secondSide;
            }
            else if (figureType == "triangle")
            {
                secondSide = double.Parse(Console.ReadLine());
                area = firstSide * secondSide/2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
