using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal totalPrice = 0;
            switch (typeGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = people * 8.45M;
                            if (people >= 30)
                            {
                                totalPrice = totalPrice - totalPrice * 0.15M;
                            }
                            break;
                        case "Saturday":
                            totalPrice = people * 9.80M;
                            if (people >= 30)
                            {
                                totalPrice = totalPrice - totalPrice * 0.15M;
                            }
                            break;
                        case "Sunday":
                            totalPrice = people * 10.46M;
                            if (people >= 30)
                            {
                                totalPrice = totalPrice - totalPrice * 0.15M;
                            }
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = people * 10.90M;
                            if (people >= 100)
                            {
                                totalPrice = totalPrice - 109.0M;
                            }
                            break;
                        case "Saturday":
                            totalPrice = people * 15.60M;
                            if (people >= 100)
                            {
                                totalPrice = totalPrice - 156.0M;
                            }
                            break;
                        case "Sunday":
                            totalPrice = people * 16.0M;
                            if (people >= 100)
                            {
                                totalPrice = totalPrice - 160.0M;
                            }
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = people * 15.0M;
                            if (people >= 10 && people <= 20)
                            {
                                totalPrice = totalPrice - totalPrice * 0.05M;
                            }
                            break;
                        case "Saturday":
                            totalPrice = people * 20.0M;
                            if (people >= 10 && people <= 20)
                            {
                                totalPrice = totalPrice - totalPrice * 0.05M;
                            }
                            break;
                        case "Sunday":
                            totalPrice = people * 22.50M;
                            if (people >= 10 && people <= 20)
                            {
                                totalPrice = totalPrice - totalPrice * 0.05M;
                            }
                            break;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
