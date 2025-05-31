using System;
using System.Globalization;


namespace EstruturaRepeticaoFor
{
    class Program
    {
        static void Main(string[] args) {

            Console.Write("Quantos número serão inseridos? ");
            int n = int.Parse(Console.ReadLine()!), soma = 0;
            int[] numVet = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Insira o {i}° número: ");
                numVet[i - 1] = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"O {i}° valor é: {numVet[i - 1]}");
                soma += numVet[i - 1];
            }
            string texto = string.Join(", ", numVet[..^1]) + " E " + numVet[^1];

            Console.WriteLine($"A soma de {texto} é {soma}!");
        }
    }
}