using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] inputArr = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int rotation = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rotation; i++)
            //{
            //    //51 47 32 61 21
            //    int firstElement = inputArr[0]; //51
            //    int[] currentArr = new int[inputArr.Length]; //0 0 0 0 0 

            //    for (int j = 1; j < inputArr.Length; j++)
            //    {
            //        currentArr[j - 1] = inputArr[j]; 
            //    }

            //    currentArr[currentArr.Length - 1] = firstElement;
            //    inputArr = currentArr;
            //}

            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstElement = inputArray[0];

                int[] temporary = new int[inputArray.Length];
                for (int j = 1; j < inputArray.Length; j++)
                {
                    temporary[j - 1] = inputArray[j];
                }

                temporary[inputArray.Length - 1] = firstElement;
                inputArray = temporary;
            }

            Console.WriteLine(string.Join(' ', inputArray));
        }
    }
}
