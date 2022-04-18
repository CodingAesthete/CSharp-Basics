using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool check = true;

            for (int i = 1111; i <= 9999; i++)
            {
                string currNum = i.ToString();

                for (int e = 0; e < currNum.Length; e++)
                {
                    int currDigit = int.Parse(currNum[e].ToString());

                    if (currDigit == 0)
                    {
                        check = false;
                        break;
                    }
                    if (input % currDigit != 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Console.Write(i + " ");
                }
                check = true;
            }
        }
    }
}
