using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Entities;

namespace Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask how many employees
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            //Create a list to hold employees
            List<Employee> employees = new List<Employee>();

            //Loop through the number of employees
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                //Ask if the employee is outsourced
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                //Ask for employee details
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                //If outsourced, ask for additional charge
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            //Print the payment for each employee
            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp); // This will call the overridden ToString method
            }
        }
    }
}
