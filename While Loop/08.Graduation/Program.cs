using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double note = 0;
            int badWay = 0;
            int countNotes = 0;

            while (countNotes != 12)
            {
                countNotes++;
                double currNote = double.Parse(Console.ReadLine());
                note += currNote;

                if (currNote < 4.00)
                {
                    badWay++;
                }

                if (badWay == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {countNotes-1} grade");
                    return;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {(note*1.0/countNotes):f2}");
        }
    }
}
