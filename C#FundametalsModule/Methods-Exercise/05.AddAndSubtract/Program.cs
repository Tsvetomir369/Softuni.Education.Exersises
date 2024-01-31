using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractFromResult(firstNum, secondNum, thirdNum));
        }

        static int SumFirstNumAndSecondNum (int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        static int SubtractFromResult (int firstNum, int secondnum, int thirdNum)
        {
            return (SumFirstNumAndSecondNum(firstNum, secondnum) - thirdNum);
        }
    }
}
