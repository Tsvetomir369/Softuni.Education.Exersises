using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntLoading = 0;
            int dishes = 0;
            int pots = 0;
            bool noMoreAgent = false;
            int cntBottlesCleaningAgent = int.Parse(Console.ReadLine());
            int agentInMililitres = cntBottlesCleaningAgent * 750;           
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                cntLoading++;
                int cntDishes = int.Parse(inputCommand);               
                if (cntLoading % 3 == 0)
                {
                    agentInMililitres -= cntDishes * 15;
                    pots += cntDishes;
                }
                else
                {
                    agentInMililitres -= cntDishes * 5;
                    dishes += cntDishes;
                }

                if (agentInMililitres < 0)
                {
                    noMoreAgent = true;
                    break;
                }

                inputCommand = Console.ReadLine();
            }

            if (noMoreAgent)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(agentInMililitres)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {agentInMililitres} ml.");
            }
        }
    }
}
