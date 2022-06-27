using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                string serialNumber = command[0];

                string itemName = command[1];

                int itemQuantity = int.Parse(command[2]);

                decimal itemPrice = decimal.Parse(command[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = item;
                box.ItemQuantity = itemQuantity;





                boxes.Add(box);

            }

            foreach (var currentBox in boxes.OrderByDescending(x => x.priceForABox))
            {
                Console.WriteLine($"{currentBox.SerialNumber}");
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.priceForABox:F2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal priceForABox => Item.Price * ItemQuantity;

    }
}
