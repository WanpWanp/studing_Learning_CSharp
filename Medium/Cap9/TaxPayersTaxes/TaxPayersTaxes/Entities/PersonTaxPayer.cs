using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This file is part of the TaxPayersTaxes project.
using TaxPayersTaxes.Entities;

namespace TaxPayersTaxes.Entities
{
    internal class PersonTaxpayer : TaxPayers
    {
        // This class represents a person tax payer, inheriting from the TaxPayers base class.
        // It includes properties for healthcare expenses and methods to calculate tax.
        public double HealthcareExpenses { get; set; }

        // Default constructor
        public PersonTaxpayer()
        {
        }

        // Constructor to initialize the properties of the PersonTaxpayer class
        public PersonTaxpayer(string name, double annualIncome, double healthcareExpenses)
            : base(name, annualIncome)
        {
            HealthcareExpenses = healthcareExpenses;
        }
        // Method to calculate tax for a person tax payer, but if the persons has healthcare expenses, the tax rate is reduced by 50% in tax calculation.

        public override double Tax()
        {
            double taxRate = 0;
            if (AnnualIncome <= 20000)
            {
                taxRate = 0.15; // 15% tax rate for income below 20,000
                Console.WriteLine(taxRate);
                return AnnualIncome * taxRate; // 15% tax rate for income below 20,000
            }
            else if(AnnualIncome > 20000 && HealthcareExpenses <= 1000)
            {
                taxRate = 0.25; // 25% tax rate for income above 20,000
                Console.WriteLine(taxRate);
                return (AnnualIncome * taxRate);
            }
            else
            {
                taxRate = 0.25; // 25% tax rate for income above 20,000
                Console.WriteLine(taxRate);
                return (AnnualIncome * taxRate) - (HealthcareExpenses * 0.50); // 50% deduction for healthcare expenses
            }
        }
        /* public override double Tax()
         {
             double taxRate = 0;
             if (AnnualIncome < 20000)
             {
                 taxRate = 0.15; // 15% tax rate for income below 20,000
                 return AnnualIncome * taxRate; // 15% tax rate for income below 20,000
             }
             else
             {
                 taxRate = 0.25; // 25% tax rate for income above 20,000
                 return AnnualIncome * 0.25 - HealthcareExpenses * taxRate; // 25% tax rate minus healthcare expenses deduction
             }
         }*/

        // Method to return a string representation of the person tax payer
        public override string ToString()
        {
            ;
            return $"{Name}: R$ {Tax():F2}";

        }

    }
}
