// Importa funcionalidades básicas do .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


// Importa a classe base Account, que está no mesmo namespace
using UpcastingDowncasting.Entities;

namespace UpcastingDownscasting // Define o namespace onde a classe está inserida

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de Account com dados iniciais
            Account account = new Account(1001, "Alex", 00.0);
            // Cria uma instância de BusinessAccount com dados iniciais
            BusinessAccount bAccount = new BusinessAccount(1001, "Maria", 500.0, 400.0);

            //Upcasting: atribuição de uma instância de BusinessAccount a uma variável do tipo Account
            Account acc1 = bAccount; // Isso é possível porque BusinessAccount "é um" Account (herança)
            Account acc2 = new BusinessAccount(1002, "Bob", 300.0, 200.0); // Também é válido
            Account acc3 = new SavingsAccount(1003, "Anna", 500.0, 0.01); // Upcasting para SaveAccount

            // Downcasting: conversão de uma variável do tipo Account para BusinessAccount
            //BusinessAccount acc4 = acc2; // Isso é seguro porque acc2 foi originalmente criado como BusinessAccount
            BusinessAccount acc4 = (BusinessAccount)acc2; // Downcasting explícito necessário
            acc4.Loan(100.0); // Chama o método Loan da BusinessAccount
                              //acc2.loan(200.0); // Chama o método Loan da BusinessAccount através de acc2, mas não aceito pois
                              //acc2 é do tipo Account,
                              // e o loan está contido em Busness account. para chamar o método Loan, é necessário fazer o downcasting

            //BusinessAccount acc5 = (BusinessAccount)acc3; // Downcasting explícito, mas isso pode lançar uma exceção se acc3 não for do tipo
            // BusinessAccount


            //BusinessAccount acc5 = acc3 as BusinessAccount; // Usando 'as' para tentar converter, mas isso pode resultar em null se falhar

            // testantdo se a variavel acc3 é do tipo BusinessAccount antes de fazer o downcasting
            if (acc3 is BusinessAccount businessAccount)
            {
                /*
                // Se for do tipo BusinessAccount, podemos acessar propriedades específicas
                businessAccount.Loan(100.0); // Concede um empréstimo de 100.0
                Console.WriteLine($"Novo saldo após empréstimo: {businessAccount.Balance}");
                */

                //BusinessAccount acc5 = (BusinessAccount)acc3; // Downcasting explícito necessário
                BusinessAccount acc5 = acc3 as BusinessAccount; // Usando 'as' para tentar converter, mas isso pode resultar em
                                                                // null se falhar
                acc5.Loan(100.0); // Chama o método Loan da BusinessAccount
                Console.WriteLine("Emprestio com sucesso");
            }
            else
            {
                Console.WriteLine("A conta não é do tipo BusinessAccount.");
            }

            if (acc3 is SavingsAccount)
            {
                //Console.WriteLine("A conta é do tipo BusinessAccount.");
                // Se for do tipo BusinessAccount, podemos acessar propriedades específicas
                SavingsAccount acc55 = (SavingsAccount)acc3; // Downcasting explícito necessário
                acc55.UpdateBalance(); // Chama o método UpdateBalance da SavingsAccount
                Console.WriteLine($"Novo saldo após atualização: {acc55.Balance}");
            }
            else
            {
                Console.WriteLine("A conta não é do tipo BusinessAccount.");
            }


            /*
            // É necessário verificar se a variável realmente é do tipo BusinessAccount antes de converter
            
             * if (acc2 is BusinessAccount businessAccount)
            {
                // Se for do tipo BusinessAccount, podemos acessar propriedades específicas
                businessAccount.Loan(100.0); // Concede um empréstimo de 100.0
                Console.WriteLine($"Novo saldo após empréstimo: {businessAccount.Balance}");
            }
            else
            {
                Console.WriteLine("A conta não é do tipo BusinessAccount.");
            }
            */


        }
    }
}
