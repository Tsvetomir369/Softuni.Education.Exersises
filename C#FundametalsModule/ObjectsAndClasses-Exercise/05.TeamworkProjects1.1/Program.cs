using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Team> allteams = new List<Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creator = tokens[0];
                string name = tokens[1];
                Team existingTeam = allteams.Find(t => t.Name == name);
                Team existingTeamCreator = allteams.Find(t => t.Creator == creator);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue;
                }

                if (existingTeamCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team myTeam = new Team(creator, name);
                allteams.Add(myTeam);
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] info = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string member = info[0];
                string teamName = info[1];

                Team existingTeam = allteams.Find(t => t.Name == teamName);
                Team existingTeamMember = allteams.Find(t => t.Members.Contains(member) || t.Creator == member);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (existingTeamMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                existingTeam.Members.Add(member);
            }

            List<string> allDisbandedTeams = allteams
                .Where(a => a.Members.Count == 0)
                .OrderBy(a => a.Name)
                .Select(a => a.Name)
                .ToList();

            allteams.RemoveAll(t => t.Members.Count == 0);
            List<Team> validSortedTeams = allteams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in validSortedTeams)
            {
                Console.WriteLine(team.ToString());
            }

            Console.WriteLine("Teams to disband:");

            foreach (string team in allDisbandedTeams)
            {
                Console.WriteLine(team);
            }
        }

        //public class Team
        //{
        //    public string Creator { get; set; }
        //    public string Name { get; set; }
        //    public List<string> Members { get; set; }

        //    public Team(string creator, string name)
        //    {
        //        this.Creator = creator;
        //        this.Name = name;
        //        this.Members = new List<string>();
        //    }

        //    public override string ToString()
        //    {
        //        List<string> sortedMembers = this.Members
        //            .OrderBy(a => a)
        //            .ToList();

        //        string output = $"{this.Name}\n";
        //        output += $"- {this.Creator}\n";

        //        for (int i = 0; i < sortedMembers.Count; i++)
        //        {
        //            output += $"-- {sortedMembers[i]}\n";
        //        }

        //        return output.Trim();
        //    }
        //}
    }
}
