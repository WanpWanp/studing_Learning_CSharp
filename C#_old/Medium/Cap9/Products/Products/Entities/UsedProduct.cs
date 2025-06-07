// This code is part of a .NET project targeting .NET 9.0 with C# language version 13.0.
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// import entities
using Products.Entities;

namespace Products.Entities
{
    internal class UsedProduct : Product
    {
        // Properties for the UsedProduct class
        public DateTime ManufactureDate { get; set; }
        
        // Constructor for the UsedProduct class
        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        
        // Method to calculate the price tag
        public override double PriceTag()
        {
            return base.PriceTag();
        }
        
        // Method to display product information
        public override string ToString()
        {
            return $"{base.ToString()}, Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}";
        }
    }
}
