using System;

namespace _04.VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHours = int.Parse(Console.ReadLine());
            int daysForTheBooks = int.Parse(Console.ReadLine());
            int pagesPerDay = bookPages / daysForTheBooks;
            int pagesPerHour = pagesPerDay / pagesPerHours;
            Console.WriteLine(pagesPerHour);
        }
    }
}
