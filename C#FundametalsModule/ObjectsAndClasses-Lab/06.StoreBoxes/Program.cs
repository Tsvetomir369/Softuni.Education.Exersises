using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
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
                //19861519 Dove 15 2.50
                string[] inputInfo = input.Split();

                string serialNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item(itemName, itemPrice);
                //item.Name = itemName;
                //item.Price = itemPrice;

                Box box = new Box(serialNumber, item, itemQuantity);
                //box.SerialNumber = serialNumber;
                //box.ItemQuantity = itemQuantity;
                //box.Item = item;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var currentBox in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:F2}");
            }
            //37741865
            //-- Samsung - $1000.00: 10
            //-- $10000.00
        }
    }
    //public class Item
    //{
    //    //which contains these properties: Name and Price.
    //    public Item(string name, decimal price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }
    //    public string Name { get; set; }

    //    public decimal Price { get; set; }
    //}
    //class Box
    //{
    //    //which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
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
}
