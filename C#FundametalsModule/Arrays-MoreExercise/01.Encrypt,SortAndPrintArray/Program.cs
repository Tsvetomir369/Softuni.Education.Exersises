using System;

namespace _01.Encrypt_SortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] sequenceOfStrings = new string[n];
            int[] valueOfString = new int[n];

            for (int i = 0; i < sequenceOfStrings.Length; i++)
            {
                sequenceOfStrings[i] = Console.ReadLine();

                int sumVowels = 0;
                int sumConsonant = 0;

                foreach (char index in sequenceOfStrings[i])
                {
                    if (index == 'a' || index == 'A'
                        || index == 'e' || index == 'E'
                        || index == 'i' || index == 'I'
                        || index == 'o' || index == 'O'
                        || index == 'u' || index == 'U')
                    {
                        sumVowels += ((int)index * sequenceOfStrings[i].Length);
                    }
                    else
                    {
                        sumConsonant += ((int)index / sequenceOfStrings[i].Length);
                    }
                }

                int stringSum = sumVowels + sumConsonant;
                valueOfString[i] = stringSum;
            }

            Array.Sort(valueOfString);
            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }
        }
    }
}
