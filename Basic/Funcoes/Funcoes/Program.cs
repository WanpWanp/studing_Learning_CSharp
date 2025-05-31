using System;
using System.Globalization;


namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 3 números");

            int n1 = int.Parse(Console.ReadLine()),
                n2 = int.Parse(Console.ReadLine()),
                n3 = int.Parse(Console.ReadLine());


            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior número é: " + resultado);

        }

        static int Maior(int a, int b, int c) {
            int  NumMaior;
            if (a > b && a > c)
            {
                NumMaior = a;
            }
            else if (b > c)
            {
                NumMaior = b;
            }
            else
            {
                NumMaior = c;
            }
            return NumMaior;
        }
    }
}