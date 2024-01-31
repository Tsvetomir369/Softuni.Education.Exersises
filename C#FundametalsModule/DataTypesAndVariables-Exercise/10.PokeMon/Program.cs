using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            //The distance between his targets reduces his poke power.

            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int originalValue = pokePowerN;
            int cntTargets = 0;

            while (pokePowerN >= distanceM)
            {
                if (pokePowerN == originalValue / 2 && exhaustionFactorY > 0)
                {
                    pokePowerN /= exhaustionFactorY;

                    if (pokePowerN < distanceM)
                    {
                        break;
                    }
                }
                pokePowerN -= distanceM;
                cntTargets++;
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(cntTargets);
        }
    }
}
