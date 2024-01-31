using System;
using System.Collections.Generic;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string info = Console.ReadLine();
            while (info != "end")
            {
                string[] token = info
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string city = token[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = city
                    };

                    students.Add(student);
                }
                info = Console.ReadLine();
            }

            string filteredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
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
