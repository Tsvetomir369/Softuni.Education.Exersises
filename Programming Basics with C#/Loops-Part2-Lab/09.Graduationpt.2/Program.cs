using System;

namespace _09.Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExpelled = false;
            int notPass = 0;
            double sumAllGrades = 0.0;
            int schoolClass = 1;
            string studentName = Console.ReadLine();
            while (schoolClass <= 12)
            {
                double annualAssessment = double.Parse(Console.ReadLine());
                if (annualAssessment >= 4)
                {
                    sumAllGrades += annualAssessment;
                    schoolClass++;
                }
                else
                {
                    notPass++;
                    if (notPass > 1)
                    {
                        isExpelled = true;
                        break;
                    }
                }
            }

            if (isExpelled)
            {
                Console.WriteLine($"{studentName} has been excluded at {schoolClass} grade");
            }
            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {sumAllGrades / 12:f2}");
            }
        }
    }
}
