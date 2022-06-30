using System;
using System.Collections.Generic;
namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split('/');


                if (command[0] == "end")
                {
                    break;
                }

                string type = command[0];
                string brand = command[1];
                string model = command[2];
                int powerOrWeight = int.Parse(command[3]);

                Truck truck = new Truck();
                truck.Brand = brand;
                truck.Model = model;
                truck.Weight = powerOrWeight;

                Car car = new Car();
                car.Brand = brand;
                car.Model = model;
                car.HorsePower = powerOrWeight;

                Catalog catalog = new Catalog();
                catalog.Truck = truck;
                catalog.Car = car;

            }
        }
    }
}
