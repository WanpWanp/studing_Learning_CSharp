using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Entities;





namespace Payroll.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        // Additional property for outsourced employees
        public double AdditionalCharge { get; set; }
        // Constructor
        public OutSourcedEmployee() { }
        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        // Override Payment method to include additional charge
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1; // 10% extra charge
        }
        // Override ToString method for better output
        public override string ToString()
        {
            //return $"{base.ToString()} (Outsourced)";
            //Test if this works is OutSourcedEmployee and prints other toString method with employee information
            return $"{base.ToString()} (Outsourced) - Additional Charge: {AdditionalCharge:F2} + 10%";

        }
    }
}
