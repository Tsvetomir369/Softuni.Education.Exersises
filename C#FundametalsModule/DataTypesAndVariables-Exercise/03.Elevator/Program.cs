using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numPeopleN = byte.Parse(Console.ReadLine());
            byte capacityP = byte.Parse(Console.ReadLine());
            
            byte numCourses = (byte)(numPeopleN / capacityP);
            if (numPeopleN % capacityP != 0)
            {
                numCourses += 1;
            }
            //byte numCourses = (byte)Math.Ceiling((double)numPeopleN / capacityP);
            Console.WriteLine(numCourses);
        }
    }
}
