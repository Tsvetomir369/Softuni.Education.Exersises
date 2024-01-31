using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int fiveOrMore = 0;
            int between4And5 = 0;
            int between3And4 = 0;
            int between2And3 = 0;
            double average = 0.0;
            int cntStudents = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cntStudents; i++)
            {
                double examGrade = double.Parse(Console.ReadLine());
                if (examGrade >= 5)
                {
                    fiveOrMore++;
                }
                else if (examGrade >= 4)
                {
                    between4And5++;
                }
                else if (examGrade >= 3)
                {
                    between3And4++; 
                }
                else
                {
                    between2And3++;
                }

                average += examGrade;
            }

            double percetageFiveAndMore = (fiveOrMore * 1.0 / cntStudents) * 100;
            double percetageBetween4And5 = (between4And5 * 1.0 / cntStudents) * 100;
            double percetageBetween3And4 = (between3And4 * 1.0 / cntStudents) * 100;
            double percetageBetween2And3 = (between2And3 * 1.0 / cntStudents) * 100;
            average = average / cntStudents;

            Console.WriteLine($"Top students: {percetageFiveAndMore:f2}% ");
            Console.WriteLine($"Between 4.00 and 4.99: {percetageBetween4And5:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {percetageBetween3And4:f2}% ");
            Console.WriteLine($"Fail: {percetageBetween2And3:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
