using System;
using System.Collections.Generic;
using System.Text;

namespace _05.TeamworkProjects
{
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

            foreach (var member in peopleJoined)
            {
                sb.AppendLine("-- " + member);
            }
            return sb.ToString().TrimEnd();
            //return text;
        }
    }
}
