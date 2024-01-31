using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] information = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = information[0];
                string lastName = information[1];
                int age = int.Parse(information[2]);
                string city = information[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = city
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    //class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public string HomeTown { get; set; }
    //}
}
