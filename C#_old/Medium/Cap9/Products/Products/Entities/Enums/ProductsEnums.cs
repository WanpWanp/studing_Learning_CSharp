// This code is part of a .NET project targeting .NET 9.0 with C# language version 13.0.
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// import entities
using Products.Entities;

namespace Products.Entities.Enums
{
    internal class ProductsEnums
    {
        // enums for product types comttributes is the first letter of the enum type
        public enum ProductType
        {
            Imported = 'I', // Imported product
            Used = 'U',     // Used product
            Common = 'C'    // Common product
        }

    }
}
