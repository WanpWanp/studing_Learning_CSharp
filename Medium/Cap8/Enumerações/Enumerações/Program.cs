using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumerações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order
            {
                
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PandingPaymet
            };
            OrderStatus delivered = Enum.Parse<OrderStatus>($"{OrderStatus.Delivered}");
            Console.WriteLine(order);
            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine(txt);
            string os = ($"Status: {delivered}");
            Console.WriteLine(os);

        }
    }
}
