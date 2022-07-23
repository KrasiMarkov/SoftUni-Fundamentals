using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "register")
                {
                    string username = command[1];

                    string licensePlateNumber = command[2];


                    if (!parking.ContainsKey(username))
                    {
                        parking[username] = licensePlateNumber;

                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }


                }

                else
                {
                    string username = command[1];

                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    else
                    {
                        parking.Remove(username);

                        Console.WriteLine($"{username} unregistered successfully");
                    }

                }






            }

            foreach (var item in parking)
            {
                string username = item.Key;

                string licensePlateNumber = item.Value;

                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}
