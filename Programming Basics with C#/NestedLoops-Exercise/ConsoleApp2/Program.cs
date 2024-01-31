using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageAll = 0.0;
            int counter = 0;

            int nCntPeople = int.Parse(Console.ReadLine());
            string namePresentation = string.Empty;
            while ((namePresentation = Console.ReadLine()) != "Finish")
            {               
                double averageGrade = 0.0;
                for (int i = 1; i <= nCntPeople; i++)
                {
                    counter++;
                    double grade = double.Parse(Console.ReadLine());
                    averageGrade += grade;
                    averageAll += grade;
                }
                averageGrade /= nCntPeople;               
                Console.WriteLine($"{namePresentation} - {averageGrade:f2}.");
            }

            averageAll /= counter;
            Console.WriteLine($"Student's final assessment is {averageAll:f2}.");
        }
    }
}
