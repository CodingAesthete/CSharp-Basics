using System;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int greaterNum = Math.Max(firstNum, secondNum);
            Console.WriteLine(greaterNum);
        }
    }
}
