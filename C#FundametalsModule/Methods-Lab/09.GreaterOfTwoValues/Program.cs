using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int resultInt = GetMax(first, second);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    string resultStr = GetMax(firstStr, secondStr);
                    Console.WriteLine(resultStr);
                    break;
                default:
                    break;
            }
        }

        private static int GetMax(int first, int second)
        {
            int resultInt = Math.Max(first, second);
            return resultInt;
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }

        private static string GetMax(string firstStr, string secondStr)
        {
            int comparison = firstStr.CompareTo(secondStr);

            if (comparison > 0)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
        }
    }
}
