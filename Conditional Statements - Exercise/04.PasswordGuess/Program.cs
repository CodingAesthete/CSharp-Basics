using System;

namespace _04.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPass = "s3cr3t!P@ssw0rd";
            string input = Console.ReadLine();
            if (correctPass == input)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
