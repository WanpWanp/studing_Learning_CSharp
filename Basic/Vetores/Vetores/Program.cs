using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double sum = 0;
            double media;
            string mensagem;

              for (int i = 0; i < n; i++)
            {
                Console.Write($"Tamanho {i + 1}°: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"O {i + 1}° foi {vect[i].ToString("F2", CultureInfo.InvariantCulture)}\n");
            }

              for (int i = 0;i < n; i++)
            {
                sum += vect[i];
            }
            media = sum / n;
            mensagem = string.Join(" + ", vect.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine($"{mensagem} = {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A media entre os tamanhos é de: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}