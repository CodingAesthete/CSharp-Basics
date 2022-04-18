using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volumeFishTank = length * width * height;
            double volumeForWater = (100-percent) / 100 * volumeFishTank/1000;
            Console.WriteLine(volumeForWater);
        }
    }
}
