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
            Account acc1 = new Account(1001, "Alex", 500.0); // Account é a classe base, não pode ser instanciada diretamente
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01); // SavingsAccount herda de Account

            acc1.WithDraw(10.0); // Realiza saque na conta comum
            acc2.WithDraw(10.0); // Realiza saque na conta poupança

            Console.WriteLine(acc1.Balance); // Exibe o saldo da conta comum
            Console.WriteLine(acc2.Balance); // Exibe o saldo da conta poupança


        }
    }
}
