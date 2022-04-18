using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            int mussalaClimbers = 0;
            int montBlancClimbers = 0;
            int kilimanjaroClimbers = 0;
            int k2Climbers = 0;
            int everestClimbers = 0;
            int allClimbers = 0;

            for (int i = 0; i < countGroups; i++)
            {
                int currGroup = int.Parse(Console.ReadLine());
                allClimbers += currGroup;

                if (currGroup <= 5)
                {
                    mussalaClimbers += currGroup;
                }
                else if (currGroup >= 6 && currGroup <= 12)
                {
                    montBlancClimbers += currGroup;
                }
                else if (currGroup >= 13 && currGroup <= 25)
                {
                    kilimanjaroClimbers += currGroup;
                }
                else if (currGroup >= 26 && currGroup <= 40)
                {
                    k2Climbers += currGroup;
                }
                else
                {
                    everestClimbers += currGroup;
                }
            }

            Console.WriteLine($"{(mussalaClimbers * 1.0 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(montBlancClimbers * 1.0 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(kilimanjaroClimbers * 1.0 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(k2Climbers * 1.0 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(everestClimbers * 1.0 / allClimbers * 100):f2}%");
        }
    }
}
