using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е месецът – May, June, July, August, September или October
            //На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            string month = Console.ReadLine();
            int cntNights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;

                    if (cntNights > 14)
                    {
                        studioPrice -= studioPrice * 0.3;
                        apartmentPrice -= apartmentPrice * 0.1;
                        
                    }
                    else if (cntNights > 7)
                    {
                        studioPrice -= studioPrice * 0.05; ;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;

                    if (cntNights > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;

                    if (cntNights > 14)
                    {
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                default:
                    break;
            }

            studioPrice = studioPrice * cntNights;
            apartmentPrice = apartmentPrice * cntNights;

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
