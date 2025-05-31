using System;
using System.Globalization;

namespace Struct
{
    class Program {
        static void Main(string[] args)
        {
            ClassStruct p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);
            p.y = p.x;
            Console.WriteLine(p);
        }
   
    }
}