// Importa funcionalidades básicas do .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Importa a classe base Account, que está no mesmo namespace
using Heranca.Entitites;

namespace Heranca

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de BusinessAccount com dados iniciais
            BusinessAccount account = new BusinessAccount(1001, "Alex", 500.0, 400.0);
            // Exibe os dados da conta
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Número: " + account.Number);
            Console.WriteLine("Titular: " + account.Holder);
            Console.WriteLine("Saldo: " + account.Balance.ToString("F2"));
            Console.WriteLine("Limite de Empréstimo: " + account.LoanLimit.ToString("F2"));
            
            //account.Balance = 1000.0; // Modifica o saldo da conta diretamente
        }
    }
}
