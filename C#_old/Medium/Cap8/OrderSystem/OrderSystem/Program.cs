// Importações básicas do .NET
// Importa funcionalidades básicas do .NET, como tipos primitivos e a classe Console
using System;
using System.Globalization;

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

// Importa as classes definidas na pasta Entities do seu projeto
using OrderSystem.Entities;

// Importa a enumeração OrderStatus que define os estados do pedido
using OrderSystem.Entities.Enums;

namespace OrderSystem // Define o namespace principal da aplicação
{
    public class Program
    {
        // Método principal - ponto de entrada da aplicação
        public static void Main(string[] args)
        {
            // Coleta de dados do cliente
            Console.WriteLine("Digite os dados do cliente:");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            // Converte a string digitada em uma data, respeitando o formato brasileiro
            DateTime clientDOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Cria o objeto cliente com os dados fornecidos
            Client client = new Client(clientName, clientEmail, clientDOB);

            // Cria um novo pedido com a data atual, status DELIVERED e o cliente associado
            Order order = new Order(DateTime.Now, OrderStatus.Delivered, client);

            // Solicita a quantidade de itens no pedido
            Console.Write("Quantos itens tem esse pedido? ");
            int itemCount = int.Parse(Console.ReadLine());

            // Loop para coletar os dados de cada item do pedido
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Digite os dados do item #{i + 1}:");

                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();

                Console.Write("Preço do produto: ");
                // Lê o preço respeitando o separador decimal (ex: 12.50)
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                // Cria o produto e o item do pedido
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, product, productPrice);

                // Adiciona o item à lista de itens do pedido
                order.AddItem(orderItem);
            }

            // Exibe o resumo do pedido, usando o método ToString da classe Order
            Console.WriteLine("\nRESUMO DO PEDIDO:");
            Console.WriteLine(order.ToString());
        }
    }
}
