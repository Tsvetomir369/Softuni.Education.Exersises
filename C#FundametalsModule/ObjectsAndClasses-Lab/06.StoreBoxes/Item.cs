using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StoreBoxes
{
    public class Item
    {
        //which contains these properties: Name and Price.
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
