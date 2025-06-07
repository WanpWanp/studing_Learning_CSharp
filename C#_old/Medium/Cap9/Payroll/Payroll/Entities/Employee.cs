using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Entities;

namespace Payroll.Entities
{
    internal  class Employee
    {
        // Properties
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        // Constructor
        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Method to calculate paymentl
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        // Override ToString method for better output

        public override string ToString()
        {
            return $"{Name} - Payment: {Payment():F2}";
        }

    }
}
