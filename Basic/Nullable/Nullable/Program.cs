using System;
using System.Globalization;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.00;
            Console.WriteLine($"{(x.GetValueOrDefault() == 0 ? "Valor null" : x)}");
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é null");
                if (y.HasValue)
                {
                    Console.WriteLine(y.Value);
                }
                else
                {
                    Console.WriteLine("Y é null");
                }

                double w = x ?? 5;
                double h = y ?? 5;
                Console.WriteLine($"Coalescencia nulla nesse exemplo");
                Console.WriteLine(w);
                Console.WriteLine(h);

            }
        }
    }
}