using System;
using System.Linq;

namespace temporrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weponParticles = Console.ReadLine()
                .Split('|')
                .ToArray();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] splitted = input.Split(" ").ToArray();

                switch (splitted[0])
                {
                    case "Move":
                        {
                            int index = int.Parse(splitted[2]);

                            if (splitted[1] == "Left")
                            {
                                if (index > 0 && index < weponParticles.Length)
                                {
                                    string temp = weponParticles[index];
                                    weponParticles[index] = weponParticles[index - 1];
                                    weponParticles[index - 1] = temp;
                                }
                            }

                            if (splitted[1] == "Right")
                            {
                                if (index >= 0 && index < weponParticles.Length - 1)
                                {
                                    string temp = weponParticles[index];
                                    weponParticles[index] = weponParticles[index + 1];
                                    weponParticles[index + 1] = temp;
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

                            for (int i = 0; i < weponParticles.Length; i++)
                            {
                                if (i % 2 == sign)
                                {
                                    Console.Write(weponParticles[i] + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", weponParticles)}!");
        }
    }
}
