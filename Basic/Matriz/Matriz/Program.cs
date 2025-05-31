using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a ordem da matriz: ");
            int matrizOrdem = int.Parse(Console.ReadLine());

            int [,] matriz = new int[matrizOrdem, matrizOrdem];
            for (int i = 0; i < matrizOrdem; i++)
            {
                Console.Write($"Informe o número a ser armazenado: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < matrizOrdem; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("\nMatriz informada:");
            for (int i = 0; i < matrizOrdem; i++)
            {
                for (int j = 0; j < matrizOrdem; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(); // quebra de linha após cada linha da matriz
            }

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < matrizOrdem; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }

            int count = 0;
            for (int i = 0; i < matrizOrdem; i++)
            {
                for (int j = 0; j < matrizOrdem; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            List<int> negatives = new List<int>();

            for (int i = 0; i < matrizOrdem; i++)
            {
                for (int j = 0; j < matrizOrdem; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negatives.Add(matriz[i, j]);
                    }
                }
            }

            Console.Write($"\nNegative numbers: {count}");
            Console.Write("\nNúmeros negativos encontrados:");
            foreach (int n in negatives)
            {
                Console.Write(n + " ");
            }
        }

    }
}