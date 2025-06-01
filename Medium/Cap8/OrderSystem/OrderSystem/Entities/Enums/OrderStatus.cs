// Importações básicas do .NET

// Fornece funcionalidades fundamentais como tipos primitivos, Console, DateTime, etc.
// Neste arquivo, na prática, não é necessário pois o enum não utiliza nenhuma funcionalidade externa.
using System;

// As importações abaixo são redundantes neste arquivo e podem ser removidas,
// pois o enum não depende de listas, LINQ, StringBuilder, tarefas assíncronas, nem de outras entidades do projeto:

// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using OrderSystem.Entities;
// using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities.Enums // Define o namespace onde o enum está localizado
{
    // Define o tipo enumerado OrderStatus
    // O sufixo ": int" indica que cada valor será representado por um número inteiro (opcional, pois int é o padrão)
    enum OrderStatus : int
    {
        // Pedido aguardando pagamento
        Pending = 1,

        // Pedido em processamento
        Processing = 2,

        // Pedido enviado para entrega
        Shipped = 3,

        // Pedido entregue ao cliente
        Delivered = 4,

        // Pedido cancelado
        Cancelled = 5
    }
}
