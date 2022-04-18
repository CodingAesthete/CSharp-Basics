using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int kids = 0;
            int students = 0;
            int standart = 0;
            int allTickets = 0;
            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string film = input;
                int freeSeats = int.Parse(Console.ReadLine());
                string taken;
                
                int takenSeats = 0;

                while ((taken = Console.ReadLine()) != "End")
                {
                    string type = taken;
                    if (type == "kid")
                    {
                        kids++;
                    }
                    else if (type == "student")
                    {
                        students++;
                    }else if (type == "standard")
                    {
                        standart++;
                    }

                    allTickets++;
                    takenSeats++;
                    if (takenSeats == freeSeats)
                    {
                        break;
                    }
                    
                }
                Console.WriteLine($"{film} - {(takenSeats * 1.0 / freeSeats * 100):f2}% full.");
            }
            
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(students * 1.0 / allTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(standart * 1.0 / allTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kids * 1.0 / allTickets * 100):f2}% kids tickets.");
        }
    }
}
