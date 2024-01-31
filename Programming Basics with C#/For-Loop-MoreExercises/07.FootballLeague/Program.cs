using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntFansA = 0;
            int cntFansB = 0;
            int cntFansV = 0;
            int cntFansG = 0;
            int capacityOfStadium = int.Parse(Console.ReadLine());
            int cntAllFans = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cntAllFans; i ++)
            {
                string sectorsFan = Console.ReadLine();
                switch (sectorsFan)
                {
                    case "A":
                        cntFansA += 1;
                        break;
                    case "B":
                        cntFansB += 1;
                        break;
                    case "V":
                        cntFansV += 1;
                        break;
                    case "G":
                        cntFansG += 1;
                        break;
                    default:
                        break;
                }
            }

            double percentageSectorA = cntFansA * 1.0 / cntAllFans * 100;
            double percentageSectorB = cntFansB * 1.0 / cntAllFans * 100;
            double percentageSectorV = cntFansV * 1.0 / cntAllFans * 100;
            double percentageSectorG = cntFansG * 1.0 / cntAllFans * 100;

            double percentageAllFans = cntAllFans * 1.0 / capacityOfStadium * 100;

            Console.WriteLine($"{percentageSectorA:f2}%");
            Console.WriteLine($"{percentageSectorB:f2}%");
            Console.WriteLine($"{percentageSectorV:f2}%");
            Console.WriteLine($"{percentageSectorG:f2}%");
            Console.WriteLine($"{percentageAllFans:f2}%");
        }
    }
}
