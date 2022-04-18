using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            double receivedMoney = 0;
            int presentMoney = 0;
            int countToys = 0;

            for (int i = 1; i <= age; i++)
            {
                
                if (i % 2 == 0)
                {
                    presentMoney += 10;
                    receivedMoney += presentMoney-1;
                }
                else
                {
                    countToys++;
                }
            }

            receivedMoney += (countToys * priceToy);

            if (receivedMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(receivedMoney-priceWashingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashingMachine - receivedMoney):f2}");
            }
        }
    }
}
