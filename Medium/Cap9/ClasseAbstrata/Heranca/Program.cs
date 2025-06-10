// Importa funcionalidades básicas do .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Importa a classe base Account, que está no mesmo namespace
using ClasseAbstrata.Entitites;

namespace ClasseAbstrata.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Account account = new Account(1001, "Alex", 0.0); // Cria uma instância da classe Account, mas não é possível instanciar uma classe abstrata diretamente
            BusinessAccount bAccount = new BusinessAccount(1002, "Maria", 500.0, 400.0);

            // Upcasting
            Account acc1 = bAccount;  // BusinessAccount é um Account

            // Downcasting (com verificação segura)
            if (acc1 is BusinessAccount)
            {
                BusinessAccount acc2 = (BusinessAccount)acc1;
                acc2.Loan(100.0);
                Console.WriteLine("Loan performed.");
            }

            Console.WriteLine($"Balance: {bAccount.Balance:F2}");*/

            // criando uma lista do tipo Account
            List<Account> accounts = new List<Account>();

            // adicionando uma conta SavingsAccount à lista
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new SavingsAccount(1002, "Maria", 500.0, 0.01));

            // adicionando conta bisiness à lista
            accounts.Add(new BusinessAccount(1001, "Alex", 500.0, 400.0));

            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));

        }
    }
}
