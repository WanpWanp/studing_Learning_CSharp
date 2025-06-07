// Importa funcionalidades básicas do .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Importa a classe base Account, que está no mesmo namespace
using SobreposicaoPalavrasVirtualOverrideBase.Entities;

namespace SobreposicaoPalavrasVirtualOverrideBase.Entities // Define o namespace onde a classe está inserida
{
    // Classe BusinessAccount herda de Account (relacionamento "é um")
    internal class BusinessAccount : Account
    {
        // Limite máximo disponível para empréstimos
        public double LoanLimit { get; set; }

        // Construtor padrão (necessário se quiser instanciar sem parâmetros)
        public BusinessAccount() { }

        // Construtor que inicializa os dados da conta e do limite de empréstimo
        // Usa ": base(...)" para chamar o construtor da classe base (Account)
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        // Método responsável por conceder empréstimo
        public void Loan(double amount)
        {
            // Só realiza o empréstimo se o valor solicitado for menor ou igual ao limite permitido
            if (amount <= LoanLimit)
            {
                Balance += amount; // O empréstimo aumenta o saldo da conta
            }
        }
    }
}
