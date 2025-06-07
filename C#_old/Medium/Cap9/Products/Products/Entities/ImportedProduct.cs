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
    internal class ImportedProduct : Product
    {
        // Properties for the ImportedProduct class
        public double CustomsFee { get; set; }
        // Constructor for the ImportedProduct class
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }
        // Method to calculate the price tag including customs fee
        /*public override double PriceTag()
        {
            return base.PriceTag() + CustomsFee;
        }*/
        public override double  PriceTag()
        {
            double total = Price + CustomsFee;
            return $"{Name}, Price: {total:C}, Customs Fee: {CustomsFee:C}";
        }

        // Method to display product information
        public override string ToString()
        {
            return $"{base.ToString()}, Customs Fee: {CustomsFee:C}"; //Using string interpolation to format the output
        }
    }
}
