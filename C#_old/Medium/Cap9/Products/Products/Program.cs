// This code is part of a .NET project targeting .NET 9.0 with C# language version 13.0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// import entities
using Products.Entities;
using Products.Entities.Enums;
namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int n;

            // Ask for the number of products with validation
            while (true)
            {
                Console.Write("Enter the number of products: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.WriteLine("Invalid number. Please enter a positive integer.");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                char type;

                // Ask for the product type and validate input
                while (true)
                {
                    Console.Write("Common, used or imported (c/u/i)? ");
                    string input = Console.ReadLine().ToLower();
                    if (!string.IsNullOrEmpty(input) && (input == "c" || input == "u" || input == "i"))
                    {
                        type = input[0];
                        break;
                    }
                    Console.WriteLine("Invalid type. Enter 'c' for common, 'u' for used, or 'i' for imported.");
                }

                // Ask for the product name
                Console.Write("Name: ");
                string name = Console.ReadLine();

                // Ask for the product price with validation
                double price;
                while (true)
                {
                    Console.Write("Price: ");
                    if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                        break;
                    Console.WriteLine("Invalid price. Please enter a valid non-negative number.");
                }

                // Handle each product type accordingly
                if (type == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    DateTime manufactureDate;
                    // Validate the manufacture date
                    while (true)
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        if (DateTime.TryParse(Console.ReadLine(), out manufactureDate))
                            break;
                        Console.WriteLine("Invalid date format. Use DD/MM/YYYY.");
                    }

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (type == 'i')
                {
                    double customsFee;
                    // Ask for customs fee with validation
                    while (true)
                    {
                        Console.Write("Customs fee: ");
                        if (double.TryParse(Console.ReadLine(), out customsFee) && customsFee >= 0)
                            break;
                        Console.WriteLine("Invalid fee. Please enter a valid non-negative number.");
                    }

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            // Display price tags of all products
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
