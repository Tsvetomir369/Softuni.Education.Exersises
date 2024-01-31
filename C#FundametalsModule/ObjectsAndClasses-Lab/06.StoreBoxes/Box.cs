using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StoreBoxes
{
    class Box
    {
        //which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox
            => Item.Price * ItemQuantity;
    }
}
