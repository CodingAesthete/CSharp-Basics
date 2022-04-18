using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string input;
            int passedBooks = 0;

            while ((input = Console.ReadLine()) != "No More Books")
            {
                passedBooks++;

                if (input == searchedBook)
                {
                    Console.WriteLine($"You checked {passedBooks-1} books and found it.");
                    return;
                }

            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {passedBooks} books.");
        }
    }
}
