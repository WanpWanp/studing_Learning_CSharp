// Importa funcionalidades básicas do .NET, como Console, tipos primitivos e DateTime
using System;

// Importa suporte à cultura e formatação, como para números decimais e datas
using System.Globalization;

// Importa a classe Departaments
using WorkerActivity.Entities;

// Importa a enumeração WorkerLevel
using WorkerActivity.Entities.Enums;

namespace WorkerActivity
{
    // Classe principal que contém o ponto de entrada da aplicação
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita o nome do departamento
            Console.Write("Entre com o nome do departamento: ");
            string departament = Console.ReadLine();

            // Coleta os dados do trabalhador
            Console.WriteLine("Entre com os dados solicitados!");
            Console.Write("Informe o nome do trabalhador: ");
            string nameWorker = Console.ReadLine();

            // Lê o nível do trabalhador (espera valores: Junior, MidLevel, Senior) e converte para enum
            Console.Write("Informe o Nível (Junior/Midlevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            // Solicita e converte o salário base, com cultura invariante (ponto como separador decimal)
            Console.Write("Informe o salário base do trabalhador: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Cria uma instância da classe Departaments com o nome informado
            Departaments dept = new Departaments(departament);

            // Cria uma instância da classe Worker com os dados fornecidos e o departamento associado
            Worker worker = new Worker(nameWorker, level, baseSalary, dept);

            // Solicita a quantidade de contratos que o trabalhador possui
            Console.Write("Informe a quantidade de contratos desse trabalhador: ");
            int qtdContracts = int.Parse(Console.ReadLine());

            // Loop para inserir os dados de cada contrato
            for (int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine($"\nInforme os dados do contrato #{i}:");

                // Solicita e lê a data do contrato
                Console.Write("Informe a data do contrato (DD/MM/YYYY): ");
                //DateTime date = DateTime.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


                // Solicita e lê o valor por hora do contrato
                Console.Write("Digite o valor do contrato por hora: R$ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Solicita e lê a duração do contrato em horas
                Console.Write("Informe a duração do contrato em horas: ");
                int hours = int.Parse(Console.ReadLine());

                // Cria uma instância da classe HourContract com os dados fornecidos
                HourContract contract = new HourContract(date, valuePerHour, hours);

                // Adiciona o contrato à lista de contratos do trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.WriteLine("\nContratos adicionados:");
            foreach (var c in worker.Contracts)
            {
                Console.WriteLine($"{c.Date:dd/MM/yyyy} | {c.Hours}h × R${c.ValuePerHour:F2} = R${c.TotalValue():F2}");

            }


            Console.WriteLine();

            // Solicita ao usuário a data (mês/ano) para calcular o rendimento
            Console.Write("Entre com o mês e ano (MM/YYYY) para calcular o valor ganho: ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine("\nDados sobre esse colaborador que foram coletados, segue:");
            Console.WriteLine($"Nome do colaborador: {worker.Name}");
            Console.WriteLine($"Departamento que atua: {worker.Departaments.Name}");
            Console.WriteLine($"Quantidade de contratos: {qtdContracts}");

            // Calcula e exibe os ganhos do trabalhador no mês/ano informado, com duas casas decimais
            double income = worker.Income(year, month);
            Console.WriteLine($"Ganhos no mês {month}/{year}: R$ {income.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
