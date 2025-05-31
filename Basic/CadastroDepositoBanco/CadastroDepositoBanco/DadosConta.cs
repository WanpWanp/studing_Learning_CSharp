using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDepositoBanco
{
    internal class DadosConta
    {
        private int _number = 777;

        public char Response { get; }
        public string Holder { get; set; }
        public double BankBalance { get; private set; }

        public DadosConta()
        {
        }

        public DadosConta(int number, string holder)
        {
            _number = number;
            Holder = holder;
        }
        public DadosConta(int number, string holder, double bankBalance) : this(number, holder)
        {
            BankBalance = bankBalance;
        }

        public string NewHolder(string newHolder)
        {
            Holder = newHolder;
            return Holder;
        }

        public int Number
        {
            get
            {
                return _number;
            }
            private set
            {
                _number = value;
            }

        }

        private double DepositBank(double newDeposit)
        {
            BankBalance += newDeposit;
            return BankBalance;
        }

        public double WithdrawalBank()
        {
            Console.Write("\nDeseja realizar Saque? (S/N): ");
            char response = char.Parse(Console.ReadLine().ToUpper());

            while (response != 'S' && response != 'N')
            {
                Console.WriteLine("Valor inválido. Digite apenas S ou N.");
                response = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();
            }

            while (response == 'S')
            {
                Console.Write("Digite o valor do saque: R$ ");
                double withdrawal = double.Parse(Console.ReadLine());
                const int taxa = 5;
                BankBalance = BankBalance - (taxa + withdrawal);
                Console.WriteLine($"O valor do saque foi R$ {withdrawal}, e a taxa de R$ {taxa}.");
                return BankBalance;
            }
            return BankBalance;
        }


        public void ReponseUser()
        {
            char response;
            do
            {
                Console.Write("\nDeseja realizar depósito? (S/N): ");
                response = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                while (response != 'S' && response != 'N')
                {
                    Console.WriteLine("Valor inválido. Digite apenas S ou N.");
                    response = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                }

                if (response == 'S')
                {
                    Console.Write("\nInforme o valor a ser depositado: R$ ");
                    double newBalance = double.Parse(Console.ReadLine());
                    DepositBank(newBalance);

                }
            } while (response == 'S');
        }

        public override string ToString()
        {
            return $"Conta: {Number.ToString("D4")} Titular: {Holder} Saldo: R$ {BankBalance.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}
