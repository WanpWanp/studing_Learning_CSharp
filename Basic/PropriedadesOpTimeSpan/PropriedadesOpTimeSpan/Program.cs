using System;
using System.Globalization;

namespace PropriedadesOpTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine($"Dias em T:{t.Days}");
            Console.WriteLine($"Horas em T:{t.Hours}");
            Console.WriteLine($"Minutos em T:{t.Minutes}");
            Console.WriteLine($"Segundo em T:{t.Seconds}");
            Console.WriteLine($"Milisegundos em T:{t.Milliseconds}");
            Console.WriteLine($"Ticks em T:{t.Ticks}");
            Console.WriteLine();
            Console.WriteLine($"Total de Dias em T:{t.TotalDays}");
            Console.WriteLine($"Total de horas em T:{t.TotalHours}");
            Console.WriteLine($"total de minutos em T:{t.TotalMinutes}");
            Console.WriteLine($"Total de segundos em T:{t.TotalSeconds}");
            Console.WriteLine($"Total de ticks em T:{t.TotalMilliseconds}");
            Console.WriteLine();

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 20, 5);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            TimeSpan sum = t1.Add(t2);
            Console.WriteLine(sum);
            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);

        }
    }
}