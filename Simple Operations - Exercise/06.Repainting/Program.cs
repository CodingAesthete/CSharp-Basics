using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonSquareMeters = int.Parse(Console.ReadLine());
            int paintSquareMeters = int.Parse(Console.ReadLine());
            int paintThinnerLitres = int.Parse(Console.ReadLine());
            int hoursForWork = int.Parse(Console.ReadLine());
            double amount = 1.50 * nylonSquareMeters + 14.50 * paintSquareMeters + 5.00 * paintThinnerLitres;
            amount += 0.1 * paintSquareMeters * 14.50 + 2 * 1.50 + 0.40;
            amount += 0.3 * amount * hoursForWork;
            Console.WriteLine($"{amount:f2}");
        }
    }
}
