using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de funcionários: ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            List<Employees> employees = new List<Employees>();

            for (int i = 0; i < qtdEmployees; i++)
            {
                Console.Write("Informe o nome do funcionário: ");
                string name = Console.ReadLine();
                Console.Write("Informe o código do funcionário: ");
                int codEmployees = int.Parse(Console.ReadLine());
                Console.Write("Informe o salário do funcionário:  R$ ");
                double wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                employees.Add(new Employees(name, codEmployees, wage));
            }

            Console.WriteLine($"\nDados de funcinários encontrados: ");

            foreach (Employees datas in employees) { 
                Console.WriteLine(datas);
            }

            Console.WriteLine("Informe o código do funcionário que terá o reajuste salárial: ");
            int codEmployeesCurrent = int.Parse(Console.ReadLine());

            Employees employee = employees.Find(emp => emp.EmployeeId == codEmployeesCurrent);

            if (employee != null)
            {
                Console.WriteLine("Informe a porcentagem a ser reajustado no salário: ");
                double salaryAdj = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.SalaryAdj(salaryAdj);
            } else {
                Console.WriteLine("Funcionário não registrado");
            }

            Console.WriteLine(employee.ToString());


            /*Console.WriteLine("Informe o código do funcionário que terá o reajuste saláial: ");
            int codEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem a ser reajustado no salário: ");
            double salaryAdj = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);*/
        }
    }
}