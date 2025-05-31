using System;
using System.Globalization;

namespace PropriedadesOpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D = new DateTime(1995, 08, 06, 10, 22, 15, 68);
            Console.WriteLine(D);
            Console.WriteLine($"Dia {D.Day}");
            Console.WriteLine($"Dia da semana {D.DayOfWeek}");
            Console.WriteLine($"Dia do ano {D.DayOfYear}");
            Console.WriteLine($"Hora {D.Hour}");
            Console.WriteLine($"Tipo (local ou global) {D.Kind}");
            Console.WriteLine($"Milisegundos  {D.Millisecond}");
            Console.WriteLine($"Minutos  {D.Minute}");
            Console.WriteLine($"Mês  {D.Month}");
            Console.WriteLine($"Segundos {D.Second}");
            Console.WriteLine($"Ticks {D.Ticks}");
            Console.WriteLine($"Hora do dia  {D.TimeOfDay}");
            Console.WriteLine($"Ano  {D.Year}");

            Console.WriteLine();


            Console.WriteLine($"Descrição data completa: {D.ToLongDateString()}");
            Console.WriteLine($"Descrição data curta: {D.ToShortDateString()}");
            Console.WriteLine($"Descrição data completa com hora: {D.ToLongTimeString()}");
            Console.WriteLine($"Descrição data completa com hora curta: {D.ToShortTimeString()}");
            string d = D.ToString("yyyy.MM.dd HH:mm:ss");
            Console.WriteLine($"Máscara de data: {d}");

            Console.WriteLine("-------------------------------------------------------------------------------------------");

            DateTime d2 = D.AddDays(-1);
            Console.WriteLine(d2);

        }
    }
}