using System;

namespace _05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packagesPens = int.Parse(Console.ReadLine());
            int packagesMarkers = int.Parse(Console.ReadLine());
            int litresBoardCleaner = int.Parse(Console.ReadLine());
            int percentsDiscount = int.Parse(Console.ReadLine());
            double amountBeforeDiscount = packagesPens * 5.80 + packagesMarkers * 7.20 + litresBoardCleaner * 1.20;
            double amountDue = amountBeforeDiscount- ((percentsDiscount / 100.00) * (amountBeforeDiscount));
            Console.WriteLine($"{amountDue:f2}");
        }
    }
}
