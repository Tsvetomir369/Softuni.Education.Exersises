using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            double result = GetRaisedToPower(inputNumber, count);
            Console.WriteLine(result);

        }

        static double GetRaisedToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            //int result = (int)Math.Pow(number, power);
            return result;
        }
    }
}
