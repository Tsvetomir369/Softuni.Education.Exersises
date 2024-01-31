using System;

namespace _09.GreaterofTwoValues_secondWay_
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                //int result = GetBigger(first, second);
                //Console.WriteLine(result);
                Console.WriteLine(GetBigger(first, second));
            }

            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                //char result = GetBigger(first, second);
                //Console.WriteLine(result);
                Console.WriteLine(GetBigger(first, second));
            }

            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                //string result = GetBigger(first, second); 
                //Console.WriteLine(result);
                Console.WriteLine(GetBigger(first, second));
            }

        }

        static int GetBigger (int first, int second)
        {
            int compare = first.CompareTo(second);
            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetBigger(char first, char second)
        {
            int compare = first.CompareTo(second);
            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetBigger(string first, string second)
        {
            int compare = first.CompareTo(second);
            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
