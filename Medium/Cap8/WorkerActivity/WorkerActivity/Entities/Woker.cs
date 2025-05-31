using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerActivity.Entities.Enums;

namespace WorkerActivity.Entities
{
    internal class Woker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departaments Departaments { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Woker() { }

        public Woker(string name, WorkerLevel level, double baseSalary, Departaments departaments)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departaments = departaments;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) 
        {  
            Contracts.Remove(contract); 
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
