using System;
using System.Globalization;

namespace PlaceholderConcatinterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 3;
            double saldo = 11.3006919521;
            String nome = "Theo Caires";

            Console.WriteLine("{0} tem {1} anos e tem saldo R${2} na conta bancária!", nome, idade, saldo.ToString("F2"));
            Console.WriteLine($"{nome} tem {idade} anos e saldo R${saldo:F2} na conta bancária!");
        }
    }
}