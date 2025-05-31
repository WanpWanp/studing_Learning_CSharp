using System;
using System.Globalization;

namespace FixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o número de linhas da Matriz: ");
            int lines = int.Parse(Console.ReadLine());
            Console.Write("Insira o número de colunas da Matriz: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matriz = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Informe os números por linha, separando-os por espaços: ");
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < columns; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("\n Valores informados para a matris por linhas e colunas");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"[{i},{j}] = {matriz[i, j]} ");
                }
            }
            Console.WriteLine("\nValores informados por linha (simples):");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            // Impressão estilo Excel
            Console.WriteLine("\nMatriz com índices (estilo Excel):\n");

            // Cabeçalho das colunas
            Console.Write("     "); // Espaço para o índice de linha
            for (int j = 0; j < columns; j++)
            {
                //Console.Write($"[{j},] ");
                char colunaLetra = (char)('A' + j); // A, B, C...
                Console.Write($"{colunaLetra,4}");
            }
            Console.WriteLine();

            // Conteúdo da matriz com índice de linha
            for (int i = 0; i < lines; i++)
            {
                Console.Write($"[{i + 1}] "); // Índice da linha
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.Write("Digite o número a ser localizado e informado seus vizinhos: ");
            int numberFind = int.Parse(Console.ReadLine());

            bool find = false;

            for (int i = 0;i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    char colunaLetra = (char)('A' + j); // A, B, C...
                    //Console.Write($"{colunaLetra,4}");

                    if (matriz[i, j] == numberFind)
                    {
                        find = true;

                        Console.WriteLine($"Posição(s) de {numberFind} na matriz é Linha: {i + 1}, e coluna {colunaLetra}.");

                        if (j > 0)
                        {
                            Console.WriteLine($"Vizinho a esquerda: {matriz[i, j - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Não há vizinho a esquerda");
                        }
                        if (j < columns - 1)
                        {
                            Console.WriteLine($"Vizinho a direita: {matriz[i, j + 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Não há vizinhos a direita");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Vizinho acima: {matriz[i - 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Nã há vizinho acima");
                        }
                        if (i < columns)
                        {
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Não há vizinhos abaixo");
                        }
                    }


                }
            }
            if (!find) {
                Console.WriteLine("Valor não encontrado na matriz");
            }
        }
    }
}