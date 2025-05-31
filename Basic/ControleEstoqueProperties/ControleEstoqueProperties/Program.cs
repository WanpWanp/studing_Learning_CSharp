using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 15, 500);
            produto.Nome = "Telev";
            Console.WriteLine($"{produto.Nome} {produto.Preco} {produto.Quantidade}");

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine($"Nome atualizado do produto {produto.Nome}");
            /*Console.WriteLine("Qual valor do produto? ");
            produto.Preco = double.Parse(Console.ReadLine());*/
            Console.WriteLine($"R$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Qual a quantidade do produto? ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            produto.AddEstoqe(produto.Quantidade);
            Console.WriteLine($"Quantidade atualizada do produto: {produto.Quantidade}");
        }
    }
}