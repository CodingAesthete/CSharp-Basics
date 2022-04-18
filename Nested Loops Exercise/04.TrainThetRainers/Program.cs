using System;

namespace _04.TrainThetRainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string input;
            double sumNotes = 0;
            double notes = 0;

            while ((input = Console.ReadLine()) != "Finish")
            {
                double note = 0;
                for (int i = 0; i < jury; i++)
                {
                    note += double.Parse(Console.ReadLine());
                }
                note /= jury;
                notes++;
                sumNotes += note;
                Console.WriteLine($"{input} - {note:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {(sumNotes/notes):f2}.");
        }
    }
}
