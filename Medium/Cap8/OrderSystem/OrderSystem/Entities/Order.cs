// Importações básicas do .NET

// Importa funcionalidades essenciais, como tipos primitivos e manipulação de datas
using System;

// Importa estruturas de dados como listas (List), que são utilizadas no código
using System.Collections.Generic;

// Importa funcionalidades do LINQ (não utilizadas diretamente aqui, mas úteis para consultas em listas)
using System.Linq;

// Importa recursos de manipulação de strings, como a classe StringBuilder (usada no ToString)
using System.Text;

// Importa recursos de programação assíncrona (não usados nesse arquivo)
using System.Threading.Tasks;

// Importa entidades do projeto, como Client, Product, OrderItem etc.
using OrderSystem.Entities;

// Importa enumerações, como OrderStatus
using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities // Define o namespace da entidade Order
{
    // Define a classe Order como interna (acessível apenas dentro do assembly atual)
    internal class Order
    {
        // Data e hora em que o pedido foi realizado
        public DateTime OrderDate { get; set; }

        // Status atual do pedido (Pending, Shipped, Delivered etc.)
        public OrderStatus Status { get; set; }

        // Cliente que fez o pedido
        public Client Client { get; set; }

        // Lista de itens que fazem parte do pedido
        public List<OrderItem> Items { get; set; }

        // Construtor padrão — necessário para criar objetos sem parâmetros
        public Order() { }

        // Construtor que recebe data, status e cliente na criação do pedido
        public Order(DateTime orderDate, OrderStatus status, Client client)
        {
            OrderDate = orderDate;
            Status = status;
            Client = client;
        }

        // Método para adicionar um item ao pedido
        public void AddItem(OrderItem item)
        {
            // Inicializa a lista se ainda não estiver inicializada
            if (Items == null)
            {
                Items = new List<OrderItem>();
            }
            Items.Add(item);
        }

        // Método para remover um item do pedido
        public void RemoveItem(OrderItem item)
        {
            if (Items != null && Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        // Calcula o valor total do pedido com base no subtotal de cada item
        public double Total()
        {
            double total = 0.0;
            if (Items != null)
            {
                foreach (OrderItem item in Items)
                {
                    total += item.SubTotal(); // Soma o subtotal de cada item
                }
            }
            return total;
        }

        // Sobrescreve o método ToString para exibir os detalhes do pedido formatados
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Date: {OrderDate}");
            sb.AppendLine($"Status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.Email})");
            sb.AppendLine("Items:");

            // Lista os itens se existirem
            if (Items != null && Items.Count > 0)
            {
                foreach (OrderItem item in Items)
                {
                    sb.AppendLine($"{item.Product.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}, Subtotal: {item.SubTotal():C}");
                }
            }
            else
            {
                sb.AppendLine("No items in the order."); // Caso não haja itens
            }

            // Adiciona o total ao final
            sb.AppendLine($"Total: {Total():C}");

            return sb.ToString();
        }
    }
}
