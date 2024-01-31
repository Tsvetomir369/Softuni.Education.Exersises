using System;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}", studentName, age, averageGrade);
        }
    }
}