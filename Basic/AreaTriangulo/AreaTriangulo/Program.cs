using System;
using System.Globalization;

namespace AreaTriangulo { 
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do Triangulo 1: ");
            xA = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            xB = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            xC = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com as medidas do Triangulo 2; ");

            yA = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            yB = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            yC = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Area de X {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior area é do Triangulo: {(areaX > areaY ? "A" : areaY > areaX ? "B" : "Áreas iguais")}");

            Console.WriteLine("-----------------------------------------------------------");


            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo 1: ");
            x.A = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            x.B = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            x.C = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com as medidas do Triangulo 2; ");

            y.A = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            y.B = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            y.C = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            double area_X = x.Area();

            double area_Y = y.Area();

            Console.WriteLine($"Area de X {area_X.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y {area_Y.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior area é do Triangulo: {(area_X > area_Y ? "A" : area_Y > area_X ? "B" : "Áreas iguais")}");
        }
    }
}