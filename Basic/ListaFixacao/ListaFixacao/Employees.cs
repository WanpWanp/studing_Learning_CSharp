using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFixacao
{
    internal class Employees
    {
        public string EmployeeName {  get; set; }
        public int EmployeeId { get; set; }
        public double EmployeeWage { get; set; }

        public Employees (string name, int id, double wage) {
            EmployeeName = name;
            EmployeeId = id;
            EmployeeWage = wage;
        }

        double percent;
        public double SalaryAdj(double adj)
        {
            
            percent = (EmployeeWage * adj /100);
            EmployeeWage += percent;
            return EmployeeWage;
        }
        public override string ToString()
        {
            return $"\nId: {EmployeeId} \nName: {EmployeeName}, \nSalary: R$ {EmployeeWage.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
