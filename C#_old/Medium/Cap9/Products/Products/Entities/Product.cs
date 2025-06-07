// This code is part of a .NET project targeting .NET 9.0 with C# language version 13.0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// import entities
using Products.Entities;
using Products.Entities.Enums;

namespace Products.Entities
{
    internal class Product
    {
        // Properties for the Products class
        public string Name { get; set; }
        public double Price { get; set; }
        // Constructor for the Products class

        // This constructor initializes the product with a name and price
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /*
        // Method to calculate the price
        public virtual double PriceTag()
        {
            return Price;
        }
        */

        public virtual double PriceTag()
        {
            return $"{Name}, Price: {Price:C}";
        }


        // Method to display product information
        public override string ToString()
        {
            return $"Product: Name: {Name}, Price: {Price:C}";
        }
    }
}
