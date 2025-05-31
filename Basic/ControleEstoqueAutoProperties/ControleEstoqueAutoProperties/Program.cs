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
            Console.WriteLine($"{produto.Nome} {produto.PrecoProd} {produto.QtdProd}");

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine($"Nome atualizado do produto {produto.Nome}");
            /*Console.WriteLine("Qual valor do produto? ");
            produto.Preco = double.Parse(Console.ReadLine());*/
            Console.WriteLine($"R$ {produto.PrecoProd.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Quantidade atualizada do produto: {produto.QtdProd}");
        }
    }
}