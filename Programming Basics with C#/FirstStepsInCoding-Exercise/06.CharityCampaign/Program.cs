using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cntCakes = int.Parse(Console.ReadLine());
            int cntWaffles = int.Parse(Console.ReadLine());
            int cntPancakes = int.Parse(Console.ReadLine());

            //Торта - 45 лв.
            //Гофрета - 5.80 лв.
            //Палачинка – 3.20 лв.
            double cakesPrice = cntCakes * 45;
            double wafflesPrice = cntWaffles * 5.80;
            double pancakesPrice = cntPancakes * 3.20;

            double totalPricePerDay = (cakesPrice + wafflesPrice + pancakesPrice) * confectioners;
            double totalSumCharity = days * totalPricePerDay;
            double sumAfterCosts = totalSumCharity - (totalSumCharity / 8);

            Console.WriteLine(sumAfterCosts);
        }
    }
}
