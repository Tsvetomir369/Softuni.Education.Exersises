using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int countTeams = int.Parse(Console.ReadLine());


            for (int i = 0; i < countTeams; i++)
            {
                var info = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                string creator = info[0];
                string teamName = info[1];
                //Create a team

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                var info = command.Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string person = info[0];
                string teamName = info[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.peopleJoined.Contains(person)) || 
                    teams.Any(x => x.Creator == person && x.Name == teamName))
                {
                    Console.WriteLine($"Member {person} cannot join team {teamName}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.Name == teamName);
                teams[index].peopleJoined.Add(person);
            }

            var teamsToBeDisbanded = teams
                .FindAll(x => x.peopleJoined.Count == 0)
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();

            var validTeams = teams
                .FindAll(x => x.peopleJoined.Count > 0)
                .OrderBy(x => x.Name)
                .ToList();

            Console.WriteLine(String.Join(Environment.NewLine, validTeams
                .OrderByDescending(x => x.peopleJoined.Count)
                .ThenBy(x => x.Name)
                .ToList()));

            Console.WriteLine("Teams to disband:");           
            foreach (var team in teamsToBeDisbanded)
            {
                Console.WriteLine(team);
            }   
        }


        public class Team
        {
            public string Creator { get; set; }
            public string Name { get; set; }

            public List<string> peopleJoined;

            public Team(string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                peopleJoined = new List<string>();
            }

            public override string ToString()
            {
                //string text = String.Empty;
                //text += Name + Environment.NewLine;
                //text += "-" + Creator + Environment.NewLine;

                //foreach (var member in peopleJoined)
                //{
                //    text += "--" + member + Environment.NewLine;
                //}
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Name);
                sb.AppendLine("- " + Creator);

                peopleJoined.Sort();

                foreach (var member in peopleJoined)
                {
                    sb.AppendLine("-- " + member);
                }
                return sb.ToString().TrimEnd();
                //return text;
            }
        }
    }
}
