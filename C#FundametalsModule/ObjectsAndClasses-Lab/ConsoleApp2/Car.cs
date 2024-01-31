using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower. = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}
