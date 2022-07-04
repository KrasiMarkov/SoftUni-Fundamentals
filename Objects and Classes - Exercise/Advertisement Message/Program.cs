using System;
using System.Collections.Generic;
using System.Linq;
namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < n; i++)
            {
                string[] message = new string[4];


                Random randomPhrases = new Random();

                int indexPhrases = randomPhrases.Next(0, phrases.Length);

                message[0] = phrases[indexPhrases];


                Random randomEvents = new Random();

                int indexEvents = randomEvents.Next(0, events.Length);

                message[1] = events[indexEvents];



                Random randomAuthors = new Random();

                int indexAuthors = randomAuthors.Next(0, authors.Length);

                message[2] = authors[indexAuthors];


                Random randomCities = new Random();

                int indexCities = randomCities.Next(0, cities.Length);

                message[3] = cities[indexCities];


                Console.WriteLine(string.Join(" ", message));

            }

            

        }
    }
}
