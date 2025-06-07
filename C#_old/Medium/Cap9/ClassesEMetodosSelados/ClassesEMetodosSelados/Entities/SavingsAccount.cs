using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEMetodosSelados.Entities; // Importa a classe base Account, que está no mesmo namespace

namespace ClassesEMetodosSelados.Entities
{
     class SavingsAccount : Account // Classe SaveAccount herda de Account (relacionamento "é um")
    {
        public double InterestRate { get; set; }
        public double OutterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) // Chama o construtor da classe base (Account)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            // Aplica a taxa de juros ao saldo atual
            Balance += Balance * InterestRate;

        }

        public sealed override void WithDraw(double amount) // Sobrescreve o método WithDraw da classe base
        {
            // Realiza o saque, mas não aplica taxa adicional
            //Balance -= amount;
            // Em vez disso, chama o método WithDraw da classe base para manter a lógica de saque
            base.WithDraw(amount); // Chama o método WithDraw da classe base (Account)
            Balance -= 2.0; // Subtrai o valor do saque do saldo

        }
    }
}