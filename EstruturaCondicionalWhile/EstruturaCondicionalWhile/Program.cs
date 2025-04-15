using System;
using System.Globalization;

namespace EstruturaCondicionalWhile
{
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            while (x > 0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz de {x} é {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.Write("Digite um outro número: ");
                x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Você digitou um número negativo!");
        }
    }
}