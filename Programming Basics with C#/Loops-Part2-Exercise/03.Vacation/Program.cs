using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntDays = 0;
            int cntSpend = 0;
            double excursionMoney = double.Parse(Console.ReadLine());
            double moneyHas = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (moneyHas < excursionMoney)
            {
                double money = double.Parse(Console.ReadLine());
                cntDays++;
                switch (input)
                {
                    case "spend":
                        moneyHas -= money;
                        cntSpend++;
                        if (moneyHas < 0)
                        {
                            moneyHas = 0;
                        }
                        break;
                    case "save":
                        moneyHas += money;
                        cntSpend = 0;
                        break;
                    default:
                        break;
                }

                if (cntSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{cntDays}");
                    break;
                }

                if (moneyHas >= excursionMoney)
                {
                    Console.WriteLine($"You saved the money for {cntDays} days.");
                    break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
