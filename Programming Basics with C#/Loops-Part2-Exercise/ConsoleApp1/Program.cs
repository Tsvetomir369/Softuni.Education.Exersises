using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int goalAchieving = 0;
            string command = Console.ReadLine();
            while (goalAchieving < goal)
            {
                if (command.Equals("Going home"))
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    goalAchieving += stepsLeft;
                    break;
                }
                int steps = int.Parse(command);
                goalAchieving += steps;              
                if (goalAchieving >= goal)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (goalAchieving < goal)
            {
                int diff = Math.Abs(goal - goalAchieving);
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
