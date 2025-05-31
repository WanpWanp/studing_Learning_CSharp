using System;

namespace CourseTypesCSharp
{
    class Program
    {
        static void Main (string[] args)
        {
            sbyte x = 127;
            int y = x;
            y++;
            Console.WriteLine ("Tipo int maior valor possível: " + int.MaxValue);
            Console.WriteLine("Tipo int menor valor possível: " + int.MinValue);
            Console.WriteLine(y);


            Console.WriteLine("Tipo long maior valor possível: " + long.MaxValue);
            Console.WriteLine("Tipo long menor valor possível: " + long.MinValue);

            Console.WriteLine("Tipo float maior valor possível: " + float.MaxValue);
            Console.WriteLine("Tipo float menor valor possível: " + float.MinValue);

            Console.WriteLine("Tipo double maior valor possível: " + double.MaxValue);
            Console.WriteLine("Tipo double menor valor possível: " + double.MinValue);

            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine("1 byte tem 8 bits, cada bit pode ser 0 ou 1, são as duas possíbilidades. \n");
            Console.WriteLine ("Se for calculado as possíblidades de 1 byte (8bits), temos 256 possíbilidades. \n");
            Console.WriteLine ("1 Byte pode ser armazezado até 256 valores diferentes (valores entre -128 e 127)\n");
            Console.WriteLine ("Em C# o sbyte aceita 8 bits ou seja (1 byte) Valor da variável X é: " + x +"\n");
            Console.WriteLine("-----------------------------------------------------------------------------\n\n\n");
            Console.Write("bom");
            Console.WriteLine(" Dia");
        }
    }
}