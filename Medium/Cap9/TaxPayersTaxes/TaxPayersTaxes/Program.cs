using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxPayersTaxes.Entities;

namespace TaxPayersTaxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program is designed to manage tax information for individuals and businesses.
            // First , we will create a list to store tax payers.
            List<TaxPayers> taxPayers = new List<TaxPayers>();

            // We will then prompt the user to enter the number of tax payers.
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            // We will then loop through the number of tax payers and prompt the user to enter the type of tax payer (person or company).
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                // If the user enters 'i', we will prompt them to enter the name, annual income, and healthcare expenses for a person tax payer.
                if (type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Caso tenha casa decimal use virgula");
                    Console.Write("Annual income: ");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.WriteLine("Caso tenha casa decimal use virgula");
                    Console.Write("Healthcare expenses: ");
                    double healthcareExpenses = double.Parse(Console.ReadLine());
                    // We will then create a new PersonTaxpayer object and add it to the list of tax payers.
                    taxPayers.Add(new PersonTaxpayer(name, annualIncome, healthcareExpenses));
                }
                // If the user enters 'c', we will prompt them to enter the name, annual income, and number of employees for a company tax payer.
                else if (type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Caso tenha casa decimal use virgula");
                    Console.Write("Annual income: ");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    // We will then create a new CompanyTaxPayer object and add it to the list of tax payers.
                    taxPayers.Add(new CompanyTaxPayer(name, annualIncome, numberOfEmployees));
                }
            }
            // After all tax payers have been added, we will display the total tax for each tax payer.
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayers taxPayer in taxPayers)
            {
                // We will call the ToString method of each tax payer to display their name and tax amount.
                Console.WriteLine(taxPayer);
            }
        }
    }
}
