using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cakeArea = width * lenght;
            int totalPieces = 0;
            bool noMore = false;
            string command = Console.ReadLine();
            while (command != "STOP")
            {
                int pieceOfCake = int.Parse(command);
                totalPieces += pieceOfCake;
                cakeArea -= pieceOfCake;                
                if (cakeArea < 0)
                {
                    noMore = true;
                    break;                    
                }                
                command = Console.ReadLine();
            }

            int diff = Math.Abs(cakeArea);
            if (noMore)
            {
                Console.WriteLine($"No more cake left! You need {diff} pieces more.");
            }
            else
            {
                Console.WriteLine($"{diff} pieces are left.");
            }
        }
    }
}
