using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string inputOperator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(firstNum, inputOperator, secondNum));
        }

        static double Calculation (int firstNum, 
                                   string inputOperator,
                                   int secondNum)
        {
            double result = 0.0;

            switch (inputOperator)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
