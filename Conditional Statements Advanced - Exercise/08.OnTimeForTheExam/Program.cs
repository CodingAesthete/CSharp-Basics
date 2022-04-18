using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinutes;

            if (arrivalTime > examTime)
            {
                int diff = arrivalTime - examTime;

                if (diff > 59)
                {
                    int lateHours = diff / 60;
                    int lateMinutes = diff % 60;

                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diff} minutes after the start");
                }
            }
            else if (arrivalTime == examTime || ((examTime - arrivalTime) <= 30))
            {
                int diff = examTime - arrivalTime;

                if (diff == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else
            {
                int diff = examTime - arrivalTime;

                if (diff > 59)
                {
                    int earlyHours = diff / 60;
                    int earlyMinutes = diff % 60;

                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyHours}:{earlyMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
        }
    }
}
