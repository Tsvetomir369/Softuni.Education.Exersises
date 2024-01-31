using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала[1…10000].
            //Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].
            //Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала[1…5000].
            //Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала

            int poolVolumeV = int.Parse(Console.ReadLine());
            int firstPipeP1 = int.Parse(Console.ReadLine());
            int secondPipeP2 = int.Parse(Console.ReadLine());
            double hoursH = double.Parse(Console.ReadLine());

            double litersAllPerTime = (firstPipeP1 + secondPipeP2) * hoursH;

            if (litersAllPerTime <= poolVolumeV)
            {
                Console.WriteLine($"The pool is {(litersAllPerTime / poolVolumeV) * 100:f2}% full. Pipe 1: {((firstPipeP1 * hoursH) / litersAllPerTime) * 100:f2}%. Pipe 2: {((secondPipeP2 * hoursH) / litersAllPerTime) * 100:f2}%.");
            }
            else
            {
                double litersMore = Math.Abs(litersAllPerTime - poolVolumeV);
                Console.WriteLine($"For {hoursH:f2} hours the pool overflows with {litersMore:f2} liters.");
            }
        }
    }
}
