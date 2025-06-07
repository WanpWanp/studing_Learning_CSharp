// Importações básicas do .NET
// Importa funcionalidades básicas do .NET, como tipos primitivos e a classe Console
using System;

// Importa estruturas de dados como List, Dictionary etc. (não são usadas aqui diretamente)
using System.Collections.Generic;

// Importa métodos de consulta LINQ (não usados neste arquivo, mas úteis se forem usados futuramente)
using System.Linq;

// Importa ferramentas de manipulação de strings (ex: StringBuilder, Formatações)
using System.Text;

// Importa recursos para tarefas assíncronas e paralelas (também não usados aqui)
using System.Threading.Tasks;

// Importa classes definidas no projeto, inclusive a classe Product que está em Entities
using OrderSystem.Entities;

// Importa enumerações (nesse arquivo não são usadas diretamente, mas há comentários com enum)
using OrderSystem.Entities.Enums;

// Importa entidades do projeto (nesse arquivo não são utilizadas diretamente, mas pode ser útil futuramente)
using OrderSystem.Entities;
using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities // Define o namespace da classe Client
{
    // Define a classe Client como interna (visível apenas dentro do mesmo assembly)
    internal class Client
    {
        // Nome do cliente
        public string Name { get; set; }

        // Email do cliente
        public string Email { get; set; }

        // Data de nascimento do cliente
        public DateTime DateOfBirth { get; set; }

        /*
        // Propriedades comentadas, mas planejadas para expansão futura:
        public string Phone { get; set; }        // Telefone
        public string Address { get; set; }      // Endereço
        public string City { get; set; }         // Cidade
        public string State { get; set; }        // Estado
        public string ZipCode { get; set; }      // CEP
        public string Country { get; set; }      // País
        */

        // Construtor padrão (necessário para instanciar sem passar argumentos)
        public Client()
        {
        }

        // Construtor com argumentos para inicializar diretamente as propriedades
        public Client(string name, string email, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        // Método sobrescrito ToString() que retorna uma representação textual do cliente
        public override string ToString()
        {
            // Exemplo de saída: João - (joao@email.com) - 10/03/1990
            return $"{Name} - ({Email}) - {DateOfBirth.ToShortDateString()}";
        }
    }
}
