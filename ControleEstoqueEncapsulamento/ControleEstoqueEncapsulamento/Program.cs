using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Informe os dados do produto!");
            Console.Write("Nome do produto: ");
            string nomeProd = Console.ReadLine();
            Console.Write("Quantidade no estoque do produto: ");
            int qtdProd = int.Parse(Console.ReadLine());
            Console.Write("Preço do produto: ");
            double precoProd = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProd, qtdProd, precoProd);

            Console.WriteLine("----------------------------------------------------------------------------------------\n\n");
            Console.WriteLine($"Nome: {produto.NomeProd} \nR$ {produto.PrecoProd.ToString(("F2"), CultureInfo.InvariantCulture)} \nQuantidade no estoque: {produto.QtdProd} \nValor de estoque R$ {(produto.ValorEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------------------------------------------------------------------------\n\n");

            Console.WriteLine(produto.QtdProd);
            Console.Write("Digite a quantidade a ser adionado no estoque: ");
            int qtdAdicionar = int.Parse(Console.ReadLine());
            produto.AddEstoqe(qtdAdicionar);
            Console.WriteLine($"Quantidade atualizada: {produto.QtdProd}");
            Console.WriteLine($"Valor estoque atualizado: R$ {(produto.ValorEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a quantidade a ser removido no estoque: ");
            int qtdRemove = int.Parse(Console.ReadLine());
            produto.BaixaEstoque(qtdRemove);
            Console.WriteLine($"Quantidade atualizada: {produto.QtdProd}"); 
            Console.WriteLine($"Valor estoque atualizado: R$ {(produto.ValorEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Dados do produto: {produto}");
            Console.Write("Digite a quantidade a ser adionado no estoque: ");
            int qtdAdicionar = int.Parse(Console.ReadLine());
            produto.AddEstoqe(qtdAdicionar);
            Console.WriteLine(produto.EstoqueAtualizado());

            Console.WriteLine($"\nDados do produto: {produto}");
            Console.Write("Digite a quantidade a ser removido no estoque: ");
            int qtdRemove = int.Parse(Console.ReadLine());
            produto.BaixaEstoque(qtdRemove);
            Console.WriteLine(produto.EstoqueAtualizado());
            Console.WriteLine($"\nDados do produto: {produto}");*/

            Produto produto = new Produto("TV", 15, 5000);
            Console.WriteLine(produto.GetNome() + produto.GetPreco() + produto.GetQuantidade());

            Console.Write("Digite o nome do produto: ");
            string novoNome = Console.ReadLine();
            produto.SetNome(novoNome);
            Console.WriteLine($"Nome atualizado do produto {produto.GetNome()}");
        }
    }
}