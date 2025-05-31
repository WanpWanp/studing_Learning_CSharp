using System;
using System.Globalization;

namespace TimeSpan_
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);
            TimeSpan t2 = new TimeSpan(9000000L);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 1, 45);
            Console.WriteLine(t3);
            TimeSpan t4 = new TimeSpan(10, 14, 50, 25);
            Console.WriteLine(t4);
            TimeSpan t5 = new TimeSpan(15, 15, 25, 15, 555);
            Console.WriteLine(t5);

            Console.WriteLine();

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);
        }
    }
}