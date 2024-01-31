using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetDataTypes(input);
        }

        static void GetDataTypes (string input)
        {
            switch (input)
            {
                case "int":
                    int num = int.Parse(Console.ReadLine());
                    num *= 2;
                    Console.WriteLine(num);
                    break;
                case "real":
                    double realNum = double.Parse(Console.ReadLine());
                    realNum *= 1.5;
                    Console.WriteLine($"{realNum:f2}");
                    break;
                case "string":
                    string str = Console.ReadLine();
                    Console.WriteLine($"${str}$");
                    break;
            }
        }
    }
}
