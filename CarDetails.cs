using Automobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcar_project
{
    internal class CarDetails : Program

    {
        public string Name;
        public string Model;
        public string Year;
        public string Color;
        public double Price;
        public string FuelType;

        // Method to set car details
        public void car(string name, string model, string year, string color, double price, string fuelType)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
            Price = price;
            FuelType = fuelType;
            Console.WriteLine($"Name: {name}, Model: {model}, Year: {year}, Color: {color}, Price: {price}, FuelType: {fuelType}");
        }
    }
}
