using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This file is part of the TaxPayersTaxes project.
using TaxPayersTaxes.Entities;

namespace TaxPayersTaxes.Entities
{
    internal class CompanyTaxPayer : TaxPayers
    {
        // This class represents a company tax payer, inheriting from the TaxPayers base class.
        // It includes properties for number of employees and methods to calculate tax.
        public int NumberOfEmployees { get; set; }
        // Default constructor
        public CompanyTaxPayer()
        {
        }
        // Constructor to initialize the properties of the CompanyTaxPayer class
        public CompanyTaxPayer(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        // Method to calculate tax for a company tax payer, but this method is base in employee number. If the number of employees is less than 10,
        // the tax rate is 16%, otherwise it is 14%.
        // Method to return a string representation of the company tax payer

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnnualIncome * 0.16; // 16% tax rate for companies with less than 10 employees
            }
            else
            {
                return AnnualIncome * 0.14; // 14% tax rate for companies with 10 or more employees
            }
        }
        public override string ToString()
        {
            return $"{Name}: R$ {Tax():F2}";
        }

    }

}
