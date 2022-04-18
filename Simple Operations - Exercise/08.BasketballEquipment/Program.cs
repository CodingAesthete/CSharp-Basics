using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double sneakersPrice = 0.6 * annualFee;
            double kitPrice = 0.8 * sneakersPrice;
            double ballPrice = 0.25 * kitPrice;
            double accessoiresPrice = 0.20 * ballPrice;
            double totalPrice = annualFee + sneakersPrice + kitPrice + ballPrice + accessoiresPrice;
            Console.WriteLine(totalPrice);
        }
    }
}
