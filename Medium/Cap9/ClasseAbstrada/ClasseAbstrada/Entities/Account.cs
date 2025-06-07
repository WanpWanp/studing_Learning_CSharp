// Importa funcionalidades essenciais do .NET, como tipos primitivos (int, string, double) e DateTime
using System;

// Importa listas e coleções genéricas (não usadas neste arquivo)
using System.Collections.Generic;

// Importa funcionalidades LINQ (não usadas aqui)
using System.Linq;

// Importa recursos para manipulação de strings (ex: StringBuilder — não usados aqui)
using System.Text;

// Importa suporte a tarefas assíncronas (não usado neste arquivo)
using System.Threading.Tasks;

// Importa outras entidades do projeto (neste caso desnecessário, pois estamos na mesma namespace)
using SobreposicaoPalavrasVirtualOverrideBase.Entities;

namespace SobreposicaoPalavrasVirtualOverrideBase.Entities // Define o namespace do projeto, organizando as entidades da aplicação
{
    // Define a classe Account como 'internal', visível apenas dentro do mesmo projeto
    abstract class Account
    {
        // Número da conta. Pode ser lido por outras classes, mas só alterado internamente
        public int Number { get; private set; }

        // Nome do titular. Também com acesso público de leitura e privado de escrita
        public string Holder { get; private set; }

        // Saldo da conta. Protegido contra alteração direta fora da classe
        public double Balance { get; protected set; }

        // Construtor padrão necessário para instanciar sem passar argumentos
        public Account() { }

        // Construtor completo, recebe todos os dados necessários e inicializa o objeto
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Método para realizar saque
        public virtual void WithDraw(double amount)
        {
            // Subtrai diretamente o valor solicitado do saldo
            // Pode ser melhorado com verificação de saldo ou uso de taxas
            Balance -= amount + 5.0;
        }

        // Método para realizar depósito
        public void Deposit(double amount)
        {
            // Adiciona valor ao saldo da conta
            Balance += amount;
        }
    }
}
