using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Градусите - цяло число в интервала[10…42]
            // Текст, време от денонощието - с възможности - &quot; Morning & quot;, &quot; Afternoon & quot;, &quot; Evening & quot;
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";
            if (10 <= degrees && degrees <= 18)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }
            else if (18 < degrees && degrees <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    default:
                        break;
                }
            }
            else if (degrees >= 25)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    case "Afternoon":
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
