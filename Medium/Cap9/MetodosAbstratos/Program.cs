// Importa funcionalidades básicas do .NET
using SobreposicaoPalavrasVirtualOverrideBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


// Importa a classe base Account, que está no mesmo namespace
using SobreposicaoPalavrasVirtualOverrideBase.Entities;

namespace SobreposicaoPalavrasVirtualOverrideBase // Define o namespace onde a classe está inserida

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Account acc1 = new Account(1001, "Alex", 500.0); // Account é a classe base, não pode ser instanciada diretamente
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01); // SavingsAccount herda de Account

            acc1.WithDraw(10.0); // Realiza saque na conta comum
            acc2.WithDraw(10.0); // Realiza saque na conta poupança

            Console.WriteLine(acc1.Balance); // Exibe o saldo da conta comum
            Console.WriteLine(acc2.Balance); // Exibe o saldo da conta poupança*/

            // Cria uma lista de contas do tipo Account, mas que pode conter SavingsAccount ou bisinessAccount
            List<Account> accounts = new List<Account>(); // Lista de contas do tipo Account

            // Adiciona contas SavingsAccount à lista
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01)); // Conta poupança
            accounts.Add(new SavingsAccount(1002, "Maria", 500.0, 0.01)); // Outra conta poupança

            // Adiciona contas BusinessAccount à lista
            accounts.Add(new BusinessAccount(1003, "Bob", 500.0, 400.0)); // Conta empresarial
            accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0)); // Outra conta empresarial

            // Percorre cada conta na lista, realizando um saque de 10.0
            double sum = 0.0; // Variável para acumular o saldo total
            foreach (Account account in accounts)
            {
                //account.WithDraw(10.0); // Realiza saque de 10.0 em cada conta
                sum += account.Balance; // Acumula o saldo restante após o saque
            }

            // Realiza saque de 10.0 em cada conta
            foreach (var account in accounts)
            {
                account.WithDraw(10.0); // Chama o método WithDraw de cada conta
            }

            // Exibe o saldo total após os saques
            Console.WriteLine("Total balance after withdraws: " + sum.ToString("F2")); // Formata o saldo com duas casas decimais

            // Exibe o saldo de cada conta após os saques
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Conta: {account.Number} Valor: {account.Balance.ToString("F2")}"); // Exibe o saldo de cada conta formatado com duas casas decimais
            }

            foreach (Account account in accounts)
            {
                account.WithDraw(10.0); // Realiza saque de 10.0 em cada conta
                sum += account.Balance; // Acumula o saldo restante após o saque
                Console.WriteLine($"\nConta: {account.Number} Valor: {account.Balance.ToString("F2")}");
            }
        }
    }
}
