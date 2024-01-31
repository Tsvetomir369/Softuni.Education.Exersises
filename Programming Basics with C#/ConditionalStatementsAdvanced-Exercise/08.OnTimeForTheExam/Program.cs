using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int examTimeInMinutes = (examHour * 60) + examMinutes;
            int arrivalInMinutes = (hourArrival * 60) + minutesArrival;

            int diff = Math.Abs(arrivalInMinutes - examTimeInMinutes);
            int hours = diff / 60;
            int minutes = diff % 60;
            //Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
            //Ако е пристигнал по-рано повече от 30 минути, той е подранил.
            //Ако е дошъл след часа на изпита, той е закъснял.
            if (examTimeInMinutes - arrivalInMinutes > 30)
            {
                Console.WriteLine("Early");
                if (examTimeInMinutes - arrivalInMinutes >= 60)
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else if (arrivalInMinutes <= examTimeInMinutes && examTimeInMinutes - arrivalInMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{diff} minutes before the start");
            }
            else
            {
                Console.WriteLine("Late");
                if (arrivalInMinutes - examTimeInMinutes >= 60)
                {
                    
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else 
                {                    
                    Console.WriteLine($"{diff} minutes after the start");
                }              
            }
        }
    }
}
