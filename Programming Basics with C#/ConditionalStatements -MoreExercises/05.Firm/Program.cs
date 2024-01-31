using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред са необходимите часовете – цяло число в интервала[0... 200 000]
            //На втория ред са дните, с които фирмата разполага – цяло число в интервала[0... 20 000]
            //На третия ред е броят на служителите, работещи извънредно – цяло число в интервала[0... 200]
            int hoursNeedProject = int.Parse(Console.ReadLine());
            int daysProject = int.Parse(Console.ReadLine());
            int cntPeopleOvertime = int.Parse(Console.ReadLine());

            double forEducation = daysProject * 0.1;
            double timeForWork = (daysProject - forEducation) * 8;
            int overTimeAll = cntPeopleOvertime * (daysProject * 2);
            double totalTime = Math.Floor(timeForWork  + overTimeAll);
            double diff = Math.Abs(totalTime - hoursNeedProject);

            if (totalTime >= hoursNeedProject)
            {
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{diff} hours needed.");
            }
        }
    }
}
