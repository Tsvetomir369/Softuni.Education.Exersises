using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> playTime = new Dictionary<string, int>();

            //int totalTime = 0;
            string input = Console.ReadLine();
            while (input != "start of concert")
            {
                string[] arguments = input
                    .Split("; ");
                string command = arguments[0];
                string nameBand = arguments[1];

                if (command == "Add")
                {
                    List<string> members = arguments[2]
                            .Split(", ")
                            .ToList();

                    if (!bands.ContainsKey(nameBand))
                    {
                        bands.Add(nameBand, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[nameBand].Contains(member))
                            {
                                bands[nameBand].Add(member);
                            }
                        }
                    }
                }
                else
                {
                    int time = int.Parse(arguments[2]);
                    //totalTime += time;
                    if (!playTime.ContainsKey(nameBand))
                    {
                        playTime.Add(nameBand, time);
                    }
                    else
                    {
                        playTime[nameBand] += time;
                    }                    
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {playTime.Values.Sum()}");

            foreach (var band in playTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string name = Console.ReadLine();
            Console.WriteLine(name);
            foreach (var member in bands[name])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
