using System;
using System.Globalization;

namespace CadastroDepositoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosConta dadosConta = new DadosConta();

            Console.Write("Entre com nome do titular: ");
            string name = Console.ReadLine();
            dadosConta.NewHolder(name);
            Console.Write($"Número da conta: {dadosConta.Number}");

            dadosConta.ReponseUser();

            Console.WriteLine($"{dadosConta.ToString()}");
            dadosConta.WithdrawalBank();
            Console.WriteLine($"\n{dadosConta.ToString()}");



        }
    }
}