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

namespace OrderSystem.Entities // Define o namespace da classe, agrupando entidades do sistema
{
    // Define a classe OrderItem como interna (visível apenas dentro do assembly)
    internal class OrderItem
    {
        // Produto associado ao item do pedido
        public Product Product { get; set; }

        // Quantidade do produto solicitada
        public int Quantity { get; set; }

        // Preço unitário do produto (no momento do pedido)
        public double Price { get; set; }

        // Construtor padrão sem parâmetros — necessário para instanciar sem passar valores
        public OrderItem() { }

        // Construtor com parâmetros — inicializa a quantidade, produto e preço
        public OrderItem(int quantity, Product product, double price)
        {
            Quantity = quantity;
            Product = product;
            Price = price;
        }

        // Calcula o subtotal do item (quantidade * preço)
        public double SubTotal()
        {
            return Quantity * Price;
        }

        // Retorna uma string com os detalhes do item formatado
        public override string ToString()
        {
            // Exemplo: "Camisa Polo, Quantity: 2, Price: R$80,00, Subtotal: R$160,00"
            return $"{Product.Name}, Quantity: {Quantity}, Price: {Price:C}, Subtotal: {SubTotal():C}";
        }

        /*
        // Código comentado que sugere futuras expansões da classe:

        // Identificador único do item (ex: ID do banco de dados)
        public int Id { get; set; }

        // Desconto aplicado ao item
        public decimal Discount { get; set; }

        // Status individual do item (ex: Aguardando envio, Entregue, etc.)
        public OrderItemStatus Status { get; set; }

        // Construtor alternativo com todos os campos possíveis
        public OrderItem(int id, Product product, int quantity, decimal price, decimal discount, OrderItemStatus status)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            Price = price;
            Discount = discount;
            Status = status;
        }
        */
    }
}
