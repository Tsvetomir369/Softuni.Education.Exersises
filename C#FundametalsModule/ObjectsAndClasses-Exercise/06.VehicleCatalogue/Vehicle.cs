using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public override string ToString()
        {
            //Type: { typeOfVehicle}
            //Model: { modelOfVehicle}
            //Color: { colorOfVehicle}
            //Horsepower: { horsepowerOfVehicle}
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {this.Type.ToUpper()}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Color: {this.Color}");
            stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");
            return base.ToString().TrimEnd();
        }
    }
}
