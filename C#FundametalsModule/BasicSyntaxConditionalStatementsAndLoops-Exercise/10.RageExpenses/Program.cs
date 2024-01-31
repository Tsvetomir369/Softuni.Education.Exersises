using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first input line - lost games count – integer in the range[0, 1000].
            // On the second line – headset price -floating point number in range[0, 1000].
            // On the third line – mouse price -floating point number in range[0, 1000].
            // On the fourth line – keyboard price -floating point number in range[0, 1000].
            // On the fifth line – display price -floating point number in range[0, 1000].
            int lostGamesCnt = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0.0;
            for (int i = 1; i <= lostGamesCnt; i++)
            {

                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }

                if (i % 6 == 0)
                {
                    rageExpenses += keyboardPrice;
                }

                if ( i % 12 == 0)
                {
                    rageExpenses += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
