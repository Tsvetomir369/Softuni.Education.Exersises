using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTonnageMinibus = 0.0;
            int minibus = 0;
            double priceTonnageTruck = 0.0;
            int truck = 0;
            double priceTonnageTrain = 0.0;
            int train = 0;
            int totalTonnage = 0;
            int cntLoads = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cntLoads; i++)
            {
                int cargoTonnage = int.Parse(Console.ReadLine());
                totalTonnage += cargoTonnage;
                if (cargoTonnage <= 3)
                {
                    minibus += cargoTonnage;
                    priceTonnageMinibus = minibus * 200;
                }
                else if (cargoTonnage <= 11)
                {
                    truck += cargoTonnage;
                    priceTonnageTruck = truck * 175;
                }
                else
                {
                    train += cargoTonnage;
                    priceTonnageTrain = train * 120;
                }
            }

            double averagePerTonnage = (priceTonnageMinibus + priceTonnageTruck + priceTonnageTrain) / totalTonnage;
            double percetMinibus = (minibus * 1.0 / totalTonnage) * 100;
            double percetTruck = (truck * 1.0 / totalTonnage) * 100;
            double percetTrain = (train * 1.0 / totalTonnage) * 100;

            Console.WriteLine($"{averagePerTonnage:f2}");
            Console.WriteLine($"{percetMinibus:f2}%");
            Console.WriteLine($"{percetTruck:f2}%");
            Console.WriteLine($"{percetTrain:f2}%");
        }
    }
}
