using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Facebook"-> 150 лв.
            //"Instagram"-> 100 лв.
            //"Reddit"-> 50 лв.
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
