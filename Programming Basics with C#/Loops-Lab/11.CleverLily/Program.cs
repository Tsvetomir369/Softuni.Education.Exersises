using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsLily = int.Parse(Console.ReadLine());
            double priceWashingmashine = double.Parse(Console.ReadLine());
            int priceToys = int.Parse(Console.ReadLine());

            int cntToys = 0;
            double money = 0;
            double moneyFirst = 10;
            //int moneyYears = 0;
            for (int i = 1; i <= yearsLily; i++)
            {
                if (i % 2 == 0)
                {
                    money += moneyFirst;
                    money--;
                    moneyFirst += 10;
                    //if (i == 2)
                    //{
                    //    money = 10;
                    //    money--;
                    //    continue;
                    //}
                    //moneyYears++;
                    //money += 10 + (moneyYears * 10);
                }
                else
                {
                    cntToys++;
                }
            }
            double savedMoney = money + (cntToys * priceToys);
            //double savedMoney = money + (cntToys * priceToys) - (moneyYears * 1);
            double diff = Math.Abs(savedMoney - priceWashingmashine);

            if (savedMoney >= priceWashingmashine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
