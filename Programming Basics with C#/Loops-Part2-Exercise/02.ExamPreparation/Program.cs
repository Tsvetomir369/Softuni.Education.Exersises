using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastTask = "";
            int numberProblems = 0;
            int totalSum = 0;
            bool needBreak = false;
            int badGrade = 0;
            int badAssessments = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Enough")
            {
                lastTask = input;
                int grade = int.Parse(Console.ReadLine());
                numberProblems++;
                totalSum += grade;
                if (grade <= 4)
                {
                    badGrade++;
                    if (badGrade == badAssessments)
                    {
                        needBreak = true;
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if (needBreak)
            {
                Console.WriteLine($"You need a break, {badGrade} poor grades.");
            }
            else
            {
                //double averageGrade = totalSum * 1.0 / numberProblems;
                Console.WriteLine($"Average score: {totalSum * 1.0 / numberProblems:f2}");
                Console.WriteLine($"Number of problems: {numberProblems}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
