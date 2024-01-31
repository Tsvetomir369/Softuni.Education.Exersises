using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> persons = new List<Person>();
            while (command != "End")
            {
                string[] input = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person person = new Person(input[0], input[1], int.Parse(input[2]));
                persons.Add(person);
                command = Console.ReadLine();
            }

            //var result = persons.OrderBy(p => p.Age).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            //}
            var result = persons.OrderBy(p => p.Age).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }


        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.Name} with ID: {this.Id} is {this.Age} years old.");
                return sb.ToString().TrimEnd();
            }
        }
    }
}
