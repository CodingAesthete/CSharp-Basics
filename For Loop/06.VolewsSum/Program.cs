using System;

namespace _06.VolewsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int volewsSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    volewsSum += 1;
                }
                else if (word[i] == 'e')
                {
                    volewsSum += 2;
                }
                else if (word[i] == 'i')
                {
                    volewsSum += 3;
                }
                else if (word[i] == 'o')
                {
                    volewsSum += 4;
                }
                else if (word[i] == 'u')
                {
                    volewsSum += 5;
                }
            }

            Console.WriteLine(volewsSum);
        }
    }
}
