using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace VetoresPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de produtos: ");
            int qtdP = int.Parse(Console.ReadLine());

            Product[] vectP = new Product[qtdP];

            for (int i = 0; i < qtdP; i++)
            {
                Console.Write($"Informe o nome do Produto {i + 1}°: ");
                string name = Console.ReadLine();
                vectP[i] = new Product { NameP = name};
                Console.Write($"Qual é o valor do produto {vectP[i].NameP}: R$ ");
                double price = price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vectP[i] = new Product { Price = price };
            }
            double sum = 0.0;
            for (int i = 0;i < qtdP; i++) {
                sum += vectP[i].Price;
            }
            double media = sum / qtdP;
            Console.WriteLine($"O valor medio dos produtos é: R$ {media.ToString("F2", CultureInfo.InvariantCulture
                )}");
        }
    }
}