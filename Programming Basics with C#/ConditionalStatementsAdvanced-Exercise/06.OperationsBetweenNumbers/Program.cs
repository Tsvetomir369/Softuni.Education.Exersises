using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //N1 – цяло число в интервала[0...40 000]
            //N2 – цяло число в интервала[0...40 000]
            //Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                   double result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                    }
                    break;
                case '-':
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                    }
                    break;
                case '*':
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                    }
                    break;
                case '/':
                    result = n1 / n2;

                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}"); ;
                    }
                    break;
                case '%':
                    result = n1 % n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result}");
                    }                   
                    break;
                default:
                    break;
            }
        }
    }
}
