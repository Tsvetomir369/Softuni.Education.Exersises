using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //{Serial Number} {Item Name} { Item Quantity} { itemPrice}
            //19861519 Dove 15 2.50
            //86757035 Butter 7 3.20
            //39393891 Orbit 16 1.60
            //37741865 Samsung 10 1000
            //end
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] inputInfo = input.Split();

                string serilaNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item(itemName, itemPrice);
                //item.Name = itemName;
                //item.Price = itemPrice;

                Box box = new Box(serilaNumber, item, itemQuantity);

                //box.SerialNumber = serilaNumber;
                //box.ItemQuantity = itemQuantity;
                //box.Item = item;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var currentBox in boxes.OrderByDescending(x => x.PriceForABox))
            {
                //{boxSerialNumber}
                //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
                //-- ${ boxPrice}
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($" -- ${currentBox.PriceForABox:F2}");
            }
        }
    }
    //class Box
    //{
    //    //shift + Alt + C
    //    //Serial Number, Item, Item Quantity and Price for a Box.
    //    public Box(string serialNumber, Item item, int itemQuantity)
    //    {
    //        SerialNumber = serialNumber;
    //        Item = item;
    //        ItemQuantity = itemQuantity;
    //    }
    //    public string SerialNumber { get; set; }
    //    public Item Item { get; set; }
    //    public int ItemQuantity { get; set; }
    //    public decimal PriceForABox
    //        => Item.Price * ItemQuantity;

    //}
    //public class Item
    //{
    //    public Item(string name, decimal price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }
    //    public string Name { get; set; }
    //    public decimal Price { get; set; }
    //}
}
