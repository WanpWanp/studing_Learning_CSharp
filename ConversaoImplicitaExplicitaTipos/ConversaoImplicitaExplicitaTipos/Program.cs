using System;
using System.Globalization;

namespace ConversaoImplicitaExplicitaTipos
{
    class Program
    {
        static void Main(string[] args)
        {

            float x = 4.5f;
            //ocorrendo a conversão implicita de float para double. y = x
            double y = x;
            Console.WriteLine(x + " - " + y);

            double a = 5.1;
            //casting = correção de tipos. Conversão de explicita.
            float b = (float)a;
            Console.WriteLine(a + " - " + b);

            double z;
            int i;

            z = 6.5;
            i = (int)z;
            Console.WriteLine(z + " - " + i);

            i = 5;
            z = 2;

            double resultado = i / z;
            Console.WriteLine(resultado);
            resultado = i % z;
            Console.WriteLine(resultado);

        }
    }
}