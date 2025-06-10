using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxPayersTaxes.Entities;

namespace TaxPayersTaxes.Entities
{
    internal abstract class TaxPayers
    {
        // This program is designed to manage tax information for individuals and businesses. The datas is:
        // - person: Contains information about name, healthcare expenses
        // - business: Contains information about name, and number of employees, annual income
        // - the class TaxPayers is base class for both person and business tax payers. this class contain
        //  - name: string, the name of the tax payer
        // anualIncome: decimal, the annual income of the tax payer
        // methods: tax() double abstract

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        // Constructor to initialize the properties of the TaxPayers class
        protected TaxPayers()
        {
        }

        protected TaxPayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        // Abstract method to calculate tax, to be implemented by derived classes
        public abstract double Tax();
    }
}
