using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
