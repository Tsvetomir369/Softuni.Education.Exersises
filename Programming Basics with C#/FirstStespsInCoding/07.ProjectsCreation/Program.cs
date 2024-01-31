using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Името на архитекта - текст
            //Брой на проектите - цяло число в интервала[0… 100]
            string architectName = Console.ReadLine();
            int projectsCnt = int.Parse(Console.ReadLine());
            int hoursNeed = projectsCnt * 3;

            Console.WriteLine($"The architect {architectName} will need {hoursNeed} hours to complete {projectsCnt} project/s.");
        }
    }
}
