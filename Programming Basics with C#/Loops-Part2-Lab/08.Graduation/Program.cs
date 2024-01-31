using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumGrades = 0.0;
            string name = Console.ReadLine();
            int schoolClass = 1;
            while (schoolClass <= 12)
            {
                double annualAssessment = double.Parse(Console.ReadLine());
                if (annualAssessment >= 4.00)
                {
                    sumGrades += annualAssessment;
                    schoolClass++;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12:f2}");
        }
    }
}
