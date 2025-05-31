using System;
using System.Globalization;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int num3;

            double res;

            num1 = 2;
            num2 = 3;
            num3 = 4;
            res = 0;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            Console.WriteLine($"Equeção do segungo grau: {a}x² {b}x {c} = 0");
            Console.WriteLine("Formula de Baskara: -b + √b² - 4ac /2a");
            Console.WriteLine($"{b} + √{b}² - 4 * {a} * {c} / 2 * {a}");


            Console.WriteLine($"{num1} + {num2} = {res = num1 + num2}");
            Console.WriteLine($"{num2} - {num1} = {res = num2 - num1}");
            Console.WriteLine($"{num1} + {num2} * {num3} = {num1 + num2 * num3}");
            Console.WriteLine($"({num1} + {num2}) * {num3} = {res = (num1 + num2) * num3}");
            Console.WriteLine($"{num2} * {num3} = {res = num2 * num3}");
            Console.WriteLine($"{17} % {2} = {res = 17 % 2}");
            Console.WriteLine($"{num3} / {num2} = {res = num3 / num2}");
        }
    }
}