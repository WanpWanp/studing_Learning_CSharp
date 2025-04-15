using System;
using System.Globalization;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 5; // false
            bool c2 = 5 > 5; // false
            bool c3 = 2 > 5 || 5 > 5; // false
            bool c4 = 2 > 5 && 5 > 5; // false
            bool c5 = 2 > 5 && 5 == 5; // false
            bool c6 = 2 < 5 && 5 == 5;// true
            bool c7 = 2 < 5 && 5 == 5; // true

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c1 || c7 && c5 /*false*/);

        }
    }
}