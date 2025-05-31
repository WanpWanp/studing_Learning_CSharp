using System;
using System.Globalization;

namespace DateTimeKind_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nasc = new DateTime(1995, 8, 05, 10, 22, 00, DateTimeKind.Local);
            DateTime nasc1 = new DateTime(1995, 8, 05, 10, 22, 00, DateTimeKind.Utc);
            DateTime nasc2 = new DateTime(1995, 8, 05, 10, 22, 00);

            Console.WriteLine($"Nasc: {nasc}");
            Console.WriteLine($"Nasc com Kind: {nasc.Kind}");
            Console.WriteLine($"Nasc local: {nasc.ToLocalTime()}");
            Console.WriteLine($"Nasc local: {nasc.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"Nasc: {nasc1}");
            Console.WriteLine($"Nasc com Kind: {nasc1.Kind}");
            Console.WriteLine($"Nasc local: {nasc1.ToLocalTime()}");
            Console.WriteLine($"Nasc local: {nasc1.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"Nasc: {nasc2}");
            Console.WriteLine($"Nasc com Kind: {nasc2.Kind}");
            Console.WriteLine($"Nasc com Kind: {(nasc2.Kind == DateTimeKind.Unspecified ? "Local" : "UTC")}");
            Console.WriteLine($"Nasc local: {nasc2.ToLocalTime()}");
            Console.WriteLine($"Nasc local: {nasc2.ToUniversalTime()}");

            Console.WriteLine();
            Console.WriteLine("ISO 8601");

            DateTime date = DateTime.Parse("2000-06-11 19:05:09");
            Console.WriteLine($"Data: {date}");
            DateTime date2 = DateTime.Parse("2011-05-19T06:11:08Z");
            Console.WriteLine($"Data:`{date2}");

            Console.WriteLine();

            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Date com Kind: {date.Kind}");
            Console.WriteLine($"Date com Kind: {(date.Kind == DateTimeKind.Unspecified ? "Local" : "UTC")}");
            Console.WriteLine($"Date local: {date.ToLocalTime()}");
            Console.WriteLine($"Date local: {date.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"Date2: {date2}");
            Console.WriteLine($"Date2 com Kind: {date2.Kind}");
            Console.WriteLine($"Date2 local: {date2.ToLocalTime()}");
            Console.WriteLine($"Date2 Uni: {date2.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine(date2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // ! Cuidado
            Console.WriteLine(date2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));



        }
    }
}