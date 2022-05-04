using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumCoins = 0;
            
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1)
                {
                    sumCoins = sumCoins + coins;
                }
                else if (coins == 0.2)
                {
                    sumCoins = sumCoins + coins;
                }
                else if (coins == 0.5)
                {
                    sumCoins = sumCoins + coins;
                }
                else if (coins == 1)
                {
                    sumCoins = sumCoins + coins;
                }
                else if (coins == 2)
                {
                    sumCoins = sumCoins + coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }


                command = Console.ReadLine();
            }
            string nameProduct = Console.ReadLine();
            while (nameProduct != "End")
            {
                if (nameProduct == "Nuts")
                {
                    double nuts = 2.0;
                    if (sumCoins >= nuts)
                    {
                        sumCoins = sumCoins - 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (nameProduct == "Water")
                {
                    double water = 0.7;
                    if (sumCoins >= water)
                    {
                        sumCoins = sumCoins - 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (nameProduct == "Crisps")
                {
                    double crisps = 1.5;
                    if (sumCoins >= crisps)
                    {
                        sumCoins = sumCoins - 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (nameProduct == "Soda")
                {
                    double soda = 0.8;
                    if (sumCoins >= soda)
                    {
                        sumCoins = sumCoins - 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (nameProduct == "Coke")
                {
                    double coke = 1.0;
                    if (sumCoins >= coke)
                    {
                        sumCoins = sumCoins - 1.0;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                nameProduct = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoins:F2}");
        }
    }
}
