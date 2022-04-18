using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            string typeofNum = "";

            if (symbol == '+')
            {
                int result = firstNum + secondNum;

                if (result % 2 == 0)
                {
                    typeofNum = "even";
                }
                else
                {
                    typeofNum = "odd";
                }

                Console.WriteLine($"{firstNum} + {secondNum} = {result} - {typeofNum}");
            }
            else if (symbol == '-')
            {
                int result = firstNum - secondNum;

                if (result % 2 == 0)
                {
                    typeofNum = "even";
                }
                else
                {
                    typeofNum = "odd";
                }

                Console.WriteLine($"{firstNum} - {secondNum} = {result} - {typeofNum}");
            }
            else if (symbol == '*')
            {
                int result = firstNum * secondNum;

                if (result % 2 == 0)
                {
                    typeofNum = "even";
                }
                else
                {
                    typeofNum = "odd";
                }

                Console.WriteLine($"{firstNum} * {secondNum} = {result} - {typeofNum}");
            }
            else if (symbol == '/')
            {
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                    return;
                }

                double result = firstNum*1.0 / secondNum;

                Console.WriteLine($"{firstNum} / {secondNum} = {result:f2}");
            }
            else
            {
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                    return;
                }

                double result = firstNum * 1.0 % secondNum;

                Console.WriteLine($"{firstNum} % {secondNum} = {result}");
            }
        }
    }
}
