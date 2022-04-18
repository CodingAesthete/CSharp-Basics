using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badNotes = int.Parse(Console.ReadLine());
            string input;
            int counter = 0;
            int allNotes = 0;
            int notesSum = 0;
            string lastProb="";

            while ((input = Console.ReadLine()) != "Enough")
            {
                lastProb = input;
                int currNote = int.Parse(Console.ReadLine());
                notesSum += currNote;
                allNotes++;

                if (currNote <= 4)
                {
                    counter++;
                }

                if (counter == badNotes)
                {
                    Console.WriteLine($"You need a break, {counter} poor grades.");
                    return;
                }
            }

            Console.WriteLine($"Average score: {(notesSum*1.0/allNotes):f2}");
            Console.WriteLine($"Number of problems: {allNotes}");
            Console.WriteLine($"Last problem: {lastProb}");
        }
    }
}
