using System;
using System.Globalization;

namespace PraticaImpressao
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;

            int codigo = 5290;

            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}\n" + "{0}, cujo preço é R${1:F2}", produto2, preco2);
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}!");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}!");
            Console.WriteLine("Sepador decimal invariant culture: {0}!", medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}