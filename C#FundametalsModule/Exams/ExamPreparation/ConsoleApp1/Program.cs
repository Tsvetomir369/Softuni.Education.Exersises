using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> playTime = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "start of concert")
            {
                string[] arguments = input.Split("; ");
                string command = arguments[0];
                string bandName = arguments[1];

                if (command == "Add")
                {
                    List<string> members = arguments[2]
                        .Split(", ")
                        .ToList();

                    if (!bands.ContainsKey(bandName))
                    {
                        bands.Add(bandName, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[bandName].Contains(member))
                            {
                                bands[bandName].Add(member);
                            }
                        }
                    }
                }
                else
                {
                    int time = int.Parse(arguments[2]);
                    if (!playTime.ContainsKey(bandName))
                    {
                        playTime.Add(bandName, time);
                    }
                    else
                    {
                        playTime[bandName] += time;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {playTime.Values.Sum()}");

            foreach (var band in playTime.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{band.Key} => {band.Value}");
            }

            string bandInput = Console.ReadLine();
            Console.WriteLine(bandInput);
            foreach (var member in bands[bandInput])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
