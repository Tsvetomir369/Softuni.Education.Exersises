using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double forElectricity = 0.0;
            double forWater = 0.0;
            double forInternet = 0.0;
            double totalAll = 0.0;
            int months = int.Parse(Console.ReadLine());
            for (int i = 1; i <= months; i++)
            {
                double billElectricity = double.Parse(Console.ReadLine());
                forElectricity += billElectricity;
                //За ток – всеки месец е различен, ще се чете от конзолата
                //за вода – 20 лв.
                //за интернет – 15 лв.
                //за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20 %.
                double billWater = 20;
                forWater += billWater;
                double billInternet = 15;
                forInternet += billInternet;
                double otherBills = billElectricity + billWater + billInternet;
                otherBills += otherBills * 0.2;
                totalAll += otherBills;
            }

            double averagePerMonth = (forElectricity + forWater + forInternet + totalAll) / months;

            Console.WriteLine($"Electricity: {forElectricity:f2} lv");
            Console.WriteLine($"Water: {forWater:f2} lv");
            Console.WriteLine($"Internet: {forInternet:f2} lv");
            Console.WriteLine($"Other: {totalAll:f2} lv");
            Console.WriteLine($"Average: {averagePerMonth:f2} lv");
        }
    }
}
