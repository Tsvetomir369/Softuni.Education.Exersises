using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            int sumNonPrime = 0;
            int sumPrime = 0;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                bool isPrime = true;
                int num = int.Parse(command);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    counter = num / 2;
                    for (int i = 2; i <= counter; i++)
                    {
                        if (num % i == 0)
                        {
                            sumNonPrime += num;
                            isPrime = false;
                            break;
                        }
                    }
                    //other way
                    //for (int i = 2; i <= Math.Sqrt(num); i++)
                    //{
                    //    if (num % i == 0)
                    //    {
                    //        isPrime = false;
                    //        sumNonPrime += num;
                    //        break;
                    //    }
                    //}
                    if (isPrime)
                    {
                        sumPrime += num;
                    }                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}