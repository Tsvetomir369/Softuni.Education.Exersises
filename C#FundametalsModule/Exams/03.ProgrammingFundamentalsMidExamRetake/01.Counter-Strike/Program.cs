using System;

namespace _01.Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonBattles = 0;
            //int battles = 0;
            bool isEnough = true;
            string input = Console.ReadLine();
            while (input?.ToUpper() != "END OF BATTLE")
            {
                int distance = int.Parse(input);
                //battles++;
                if (energy < distance)
                {
                    isEnough = false;
                    break;
                }
                energy -= distance;
                wonBattles++;
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }

                input = Console.ReadLine();
            }

            if (isEnough == true)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy ");
            }
        }
    }
}
