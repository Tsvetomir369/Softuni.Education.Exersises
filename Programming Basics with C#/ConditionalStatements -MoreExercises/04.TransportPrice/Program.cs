using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа числото n – брой километри – цяло число в интервала[1…5000]
            //Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта

            int kilometers = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            double priceTransport = 0.0;
            //Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.axi
            //Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            if (kilometers < 20)
            {
                switch (word)
                {
                    case "day":
                        priceTransport = 0.70 + (0.79 * kilometers);
                        break;
                    case "night":
                        priceTransport = 0.70 + (0.90 * kilometers);
                        break;
                    default:
                        break;
                }
            }
            else if (kilometers >= 100)
            {
                switch (word)
                {
                    case "day":
                    case "night":
                        priceTransport = 0.06 * kilometers;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (word)
                {
                    case "day":
                    case "night":
                        priceTransport = 0.09 * kilometers;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{priceTransport:f2}");
        }
    }
}
