using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password = password + username[i];
            }
            string pass = Console.ReadLine();
            int counter = 0;
            while (pass != password)
            {
                counter++;
                if (counter == 4)
                {
                    
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

                pass = Console.ReadLine();
            }
            if (pass == password)
            {

                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
