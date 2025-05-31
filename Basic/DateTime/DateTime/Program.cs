using System;
using System.Globalization;

namespace DateTime_
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1);
            DateTime d2 = new DateTime(1995, 08, 06);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(1995, 08, 06, 10, 00, 00);
            Console.WriteLine(d3);
            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2025.12.25 15:00:00");
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("25.12.2025 15:00:00");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.ParseExact("2025-12-25", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            string currentDate = d1.ToString("dd-MM-yyyy HH:mm:ss");
            DateTime d9 = DateTime.ParseExact(currentDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);

        }
    }
}