using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialBombNumber = bombData[0];
            int bombPower = bombData[1];

            int bombIndex = listOfNumbers.IndexOf(specialBombNumber);

            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - bombPower;
                int rightNumbers = bombIndex + bombPower;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }

                if (rightNumbers > listOfNumbers.Count - 1)
                {
                    rightNumbers = listOfNumbers.Count - 1;
                }

                listOfNumbers.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

                bombIndex = listOfNumbers.IndexOf(specialBombNumber);
            }

            int sum = listOfNumbers.Sum();
            
            //int sum = 0;

            //foreach (var item in listOfNumbers)
            //{
            //    sum += item;
            //}

            Console.WriteLine(sum);
        }
    }
}
