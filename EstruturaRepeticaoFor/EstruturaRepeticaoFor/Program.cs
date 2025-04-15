using System;
using System.Globalization;


namespace EstruturaRepeticaoFor
{
    class Program
    {
        static void Main(string[] args) {

            Console.Write("Quantos número serão inseridos? ");
            int n = int.Parse(Console.ReadLine()!), soma = 0, x;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Insira o {i}° número: ");
                x = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"O {i}° valor é: {x}");
                soma += x;
            }
            Console.WriteLine($"A soma é {soma} ");
        }
    }
}