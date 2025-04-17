using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora1.Circuferencia(raio);
            double volume = Calculadora1.Volume(raio);
            Console.WriteLine($"Circuferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora1.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}