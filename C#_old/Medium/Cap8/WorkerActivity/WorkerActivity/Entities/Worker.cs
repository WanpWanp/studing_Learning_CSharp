// Importa funcionalidades básicas do .NET, como tipos primitivos e datas
using System;

// Importa classes para trabalhar com listas e coleções genéricas
using System.Collections.Generic;

// Importa operadores LINQ (não está sendo usado neste arquivo, pode ser removido)
using System.Linq;

// Importa funcionalidades para manipulação de texto (não está sendo usado neste arquivo)
using System.Text;

// Importa recursos para programação assíncrona, como Task (não está sendo usado neste arquivo)
using System.Threading.Tasks;

// Importa o enum WorkerLevel, que define os níveis do trabalhador
using WorkerActivity.Entities.Enums;

namespace WorkerActivity.Entities
{
    // Classe que representa um trabalhador dentro da empresa
    internal class Worker
    {
        // Nome do trabalhador
        public string Name { get; set; }

        // Nível do trabalhador (Junior, MidLevel, Senior, etc.)
        public WorkerLevel Level { get; set; }

        // Salário base fixo do trabalhador (sem incluir os contratos)
        public double BaseSalary { get; set; }

        // Departamento ao qual o trabalhador pertence
        public Departaments Departaments { get; set; }

        // Lista de contratos por hora associados ao trabalhador
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // Construtor padrão (sem parâmetros)
        public Worker() { }

        // Construtor que inicializa os dados principais do trabalhador
        public Worker(string name, WorkerLevel level, double baseSalary, Departaments departaments)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departaments = departaments;
        }

        // Adiciona um contrato à lista de contratos do trabalhador
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // Remove um contrato da lista de contratos do trabalhador
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // Calcula o rendimento total do trabalhador para um determinado mês e ano
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            // Percorre todos os contratos e soma apenas os que forem do mês/ano especificado
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
