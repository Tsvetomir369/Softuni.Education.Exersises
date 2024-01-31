using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сезонът – текст - “Winter”, “Spring” или “Summer”;
            //Видът на групата – текст - “boys”, “girls” или “mixed”;
            //Брой на учениците – цяло число в интервала[1 … 10000];
            //Брой на нощувките – цяло число в интервала[1 … 100].

            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int cntStudents = int.Parse(Console.ReadLine());
            int cntNights = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (season)
            {
                case "Winter":
                    switch (typeOfGroup)
                    {
                        case "boys":
                        case "girls":
                            price = cntStudents * 9.60 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                            }

                            if (typeOfGroup == "boys")
                            {
                                Console.WriteLine($"Judo {price:f2} lv.");
                            }

                            if (typeOfGroup == "girls")
                            {
                                Console.WriteLine($"Gymnastics {price:f2} lv.");
                            }
                            break;
                        case "mixed":
                            price = cntStudents * 10 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                                Console.WriteLine($"Ski {price:f2} lv.");
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                                Console.WriteLine($"Ski {price:f2} lv.");
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                                Console.WriteLine($"Ski {price:f2} lv.");
                            }
                            else
                            {
                                Console.WriteLine($"Ski {price:f2} lv.");
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Spring":
                    switch (typeOfGroup)
                    {
                        case "boys":
                        case "girls":
                            price = cntStudents * 7.20 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                            }

                            if (typeOfGroup == "boys")
                            {
                                Console.WriteLine($"Tennis {price:f2} lv.");
                            }

                            if (typeOfGroup == "girls")
                            {
                                Console.WriteLine($"Athletics {price:f2} lv.");
                            }
                            break;
                        case "mixed":
                            price = cntStudents * 9.50 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                                Console.WriteLine($"Cycling {price:f2} lv.");
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                                Console.WriteLine($"Cycling {price:f2} lv.");
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                                Console.WriteLine($"Cycling {price:f2} lv.");
                            }
                            else
                            {
                                Console.WriteLine($"Cycling {price:f2} lv.");
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Summer":
                    switch (typeOfGroup)
                    {
                        case "boys":
                        case "girls":
                            price = cntStudents * 15 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                            }

                            if (typeOfGroup == "boys")
                            {
                                Console.WriteLine($"Football {price:f2} lv.");
                            }

                            if (typeOfGroup == "girls")
                            {
                                Console.WriteLine($"Volleyball {price:f2} lv.");
                            }
                            break;
                        case "mixed":
                            price = cntStudents * 20 * cntNights;
                            if (cntStudents >= 50)
                            {
                                price -= price * 0.5;
                                Console.WriteLine($"Swimming {price:f2} lv.");
                            }
                            else if (cntStudents >= 20)
                            {
                                price -= price * 0.15;
                                Console.WriteLine($"Swimming {price:f2} lv.");
                            }
                            else if (cntStudents >= 10)
                            {
                                price -= price * 0.05;
                                Console.WriteLine($"Swimming {price:f2} lv.");
                            }
                            else
                            {
                                Console.WriteLine($"Swimming {price:f2} lv.");
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
