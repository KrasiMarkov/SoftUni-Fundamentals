using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsValidLenght(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IsLetterOrDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (HasAtLeastTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsValidLenght(password) == true && IsLetterOrDigits(password) == true && HasAtLeastTwoDigits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool IsValidLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsLetterOrDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (char.IsLetterOrDigit(symbol) == false)
                {
                    return false;
                }


            }
            return true;
        }

        static bool HasAtLeastTwoDigits(string password)
        {
            int counter = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
