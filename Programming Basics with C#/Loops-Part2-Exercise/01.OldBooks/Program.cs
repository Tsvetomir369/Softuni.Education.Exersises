using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            string lovelyBook = Console.ReadLine();
            int cntBooks = int.Parse(Console.ReadLine());
            int checkedBooks = 0;
            while (cntBooks > 0)
            {
                string nextBook = Console.ReadLine();
                if (nextBook == lovelyBook)
                {
                    isFound = true;
                    break;
                }
                checkedBooks++;
                cntBooks--;
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
