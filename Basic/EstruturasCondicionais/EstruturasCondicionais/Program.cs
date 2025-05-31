using System;
using System.Globalization;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int hora = 1;
            Console.WriteLine("Bom dia!");

            if (x < 10)
            {
                Console.WriteLine("Boa tarde!");
            }
                Console.WriteLine("Boa noite!");

            Console.WriteLine("Digite um número");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Seu número é par!");
            }
            else {
                Console.WriteLine("Seu número é impar!");
            }

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}