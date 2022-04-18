using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = numberOfNights * 50;
                if (numberOfNights > 7 && numberOfNights<=14)
                {
                    studioPrice = 0.95 * studioPrice;
                }
                else if (numberOfNights > 14)
                {
                    studioPrice = 0.70 * studioPrice;
                }

                apartmentPrice = (numberOfNights * 65) ;

                if (numberOfNights > 14)
                {
                    apartmentPrice = apartmentPrice * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numberOfNights * 75.20;

                if (numberOfNights > 14)
                {
                    studioPrice = 0.80 * studioPrice;
                }

                apartmentPrice = numberOfNights * 68.70;

                if (numberOfNights > 14)
                {
                    apartmentPrice = apartmentPrice * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = numberOfNights * 76;

                apartmentPrice = numberOfNights * 77;

                if (numberOfNights > 14)
                {
                    apartmentPrice = apartmentPrice * 0.9;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
