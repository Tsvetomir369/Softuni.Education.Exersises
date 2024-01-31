using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                switch (letter)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
