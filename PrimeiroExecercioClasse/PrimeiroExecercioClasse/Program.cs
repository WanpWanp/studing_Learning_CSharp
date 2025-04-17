using System;
using System.Globalization;
using PrimeiroExecercioClasse;

namespace PrimeiroExercicioClasse {
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa.nome = Console.ReadLine();
            Console.Write($"Digite a idade de {pessoa.nome}: ");
            pessoa.idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"{pessoa.nome} tem {pessoa.idade} anos");

            Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write($"Digite a idade de {pessoa2.nome}: ");
            pessoa2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"{pessoa2.nome} tem {pessoa2.idade} anos");

            Console.WriteLine($"A pessoa mais velha é: {(pessoa.idade > pessoa2.idade ? pessoa.nome : pessoa2.idade > pessoa.idade ? pessoa2.nome : "Idades iguais!")}\n\n");

            Console.WriteLine("------------------------------------------------------------------------------------------");

            Funcionario funcionario = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.Write("Informe o nome do primeiro funcionário: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salário de {funcionario.nome}: R$");
            funcionario.salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"{funcionario.nome} recebe RS {funcionario.salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Informe o nome do primeiro funcionário: ");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salário de {funcionario2.nome}: R$");
            funcionario2.salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"{funcionario2.nome} recebe RS {funcionario2.salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"A média dos salários é: {((funcionario.salario + funcionario2.salario) / 2).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}