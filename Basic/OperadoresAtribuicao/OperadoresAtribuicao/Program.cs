using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1;

            string s = "A B C";

            Console.WriteLine(num1);

            num1 += 2;
            Console.WriteLine(num1);

            num1 --;
            Console.WriteLine(num1);

            s += " D E F";
            Console.WriteLine(s);
        }
    }
}