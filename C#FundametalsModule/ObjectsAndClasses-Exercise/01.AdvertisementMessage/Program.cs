using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(AdvertisementMessage.GenerateMessage());
            //}

            string[] phrases = new string[]
            {
                "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
            };

            string[] events = new string[]
            {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            for (int i = 0; i < n; i++)
            {
                
                Random rand = new Random();
                string message = phrases[rand.Next(0, phrases.Length)] + " ";
                message += events[rand.Next(0, events.Length)] + " ";
                message += authors[rand.Next(0, authors.Length)] + " - ";
                message += cities[rand.Next(0, cities.Length)];

                Console.WriteLine(message);    
            }   
        }

        //public class AdvertisementMessage
        //{
        //    public static string[] phrases = new string[]
        //    {
        //    "Excellent product.",
        //    "Such a great product.",
        //    "I always use that product.",
        //    "Best product of its category.",
        //    "Exceptional product.",
        //    "I can’t live without this product."
        //    };

        //    public static string[] events = new string[]
        //    {
        //    "Now I feel good.",
        //    "I have succeeded with this product.",
        //    "Makes miracles. I am happy of the results!",
        //    "I cannot believe but now I feel awesome.",
        //    "Try it yourself, I am very satisfied.",
        //    "I feel great!"
        //    };

        //    public static string[] authors = new string[]
        //    {
        //    "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        //    };

        //    public static string[] cities = new string[]
        //    {
        //    "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        //    };

        //    public static string GenerateMessage()
        //    {
        //        Random randMessage = new Random();

        //        string currentPhrases = phrases[randMessage.Next(0, phrases.Length)];
        //        string currentEvents = events[randMessage.Next(0, events.Length)];
        //        string currentAuthors = authors[randMessage.Next(0, authors.Length)];
        //        string currentCities = cities[randMessage.Next(0, cities.Length)];

        //        return $"{currentPhrases} {currentEvents} {currentAuthors} – {currentCities}";
        //    }
        //}
    }
}
