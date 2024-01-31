using System;
using System.Linq;

namespace _02.WeaponSmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine()
                .Split('|')
                .ToArray();

            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] splitted = input
                    .Split()
                    .ToArray();

                switch (splitted[0])
                {
                    case "Move":
                        {
                            int index = int.Parse(splitted[2]);
                            if (splitted[1] == "Left")
                            {
                                if (index > 0 && index < particles.Length)
                                {
                                    string temp = particles[index];
                                    particles[index] = particles[index - 1];
                                    particles[index - 1] = temp;
                                }
                            }

                            if (splitted[1] == "Right")
                                //gosho|pesho|moni
                            {
                                if (index >= 0 && index < particles.Length - 1)
                                {
                                    string temp = particles[index];
                                    particles[index] = particles[index + 1];
                                    particles[index + 1] = temp;
                                }
                            }
                        }
                        break;
                    case "Check":
                        {
                            int sign = 0;

                            if (splitted[1] == "Odd")
                            {
                                sign = 1; 
                            }

                            for (int i = 0; i < particles.Length; i++)
                            {
                                if (i % 2 == sign)
                                {
                                    Console.Write(particles[i] + " ");
                                }
                            }

                            Console.WriteLine();

                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("",particles)}!");
        }
    }
}
