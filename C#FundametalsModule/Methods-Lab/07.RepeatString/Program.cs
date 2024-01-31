using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countRepeat = int.Parse(Console.ReadLine());
            string result = RepeatString(input, countRepeat);
            Console.WriteLine(result);

        }

        private static string RepeatString(string input, int cntRepeat)
        {
            string result = string.Empty;

            for (int i = 0; i < cntRepeat; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
