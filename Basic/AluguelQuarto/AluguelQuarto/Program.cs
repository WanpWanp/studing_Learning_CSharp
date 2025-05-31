using System;
using System.Globalization;
using System.Xml.Linq;

namespace AluguelQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Informe a quantida de quarto a ser alugado: ");
            int qtdRoomRented = int.Parse(Console.ReadLine());
            StudentsInfo[] students = new StudentsInfo[qtdRoomRented];

            StudentsInfo[] Rooms = new StudentsInfo[10];
            
            for (int i = 0; i < qtdRoomRented; i++)
            {
                Console.Write($"Informe o nome do {i + 1}° aluno: ");
                string name = Console.ReadLine();
                students[i] = new StudentsInfo { NameStudent = name};
                students[i].EmailStudent = students[i].NameStudent + "@gmail.com";
                Console.Write($"Informe o quarto desejado de {students[i].NameStudent}: ");
                int rooNum = int.Parse(Console.ReadLine());
                Rooms[rooNum] = new StudentsInfo
                {
                    NameStudent = name,
                    EmailStudent = name + "@gamil.com"
                };
            }
            
            for (int i = 0;i < Rooms.Length; i++) {
                Console.WriteLine($"{i}° Aluno: {Rooms[i].NameStudent}, - Email: {Rooms[i].EmailStudent} - Quarto: {i}");
            }*/

            Console.Write("Informe a quantidade de quartos a serem alugados: ");
            int qtdRoomRented = int.Parse(Console.ReadLine());

            StudentsInfo[] Rooms = new StudentsInfo[10];

            for (int i = 0; i < qtdRoomRented; i++)
            {
                Console.Write($"\nInforme o nome do {i + 1}° aluno: ");
                string name = Console.ReadLine();

                // Mostrar status dos quartos
                Console.WriteLine("\nStatus dos quartos:");
                for (int j = 0; j < Rooms.Length; j++)
                {
                    if (Rooms[j] == null)
                        Console.WriteLine($"Quarto {j}: Vago");
                    else
                        Console.WriteLine($"Quarto {j}: Ocupado por {Rooms[j].NameStudent}");
                }

                Console.Write($"\nInforme o quarto desejado de {name} (0 a 9): ");
                int roomNum = int.Parse(Console.ReadLine());

                // Verifica se o quarto já está ocupado
                while (roomNum < 0 || roomNum >= 10 || Rooms[roomNum] != null)
                {
                    if (roomNum < 0 || roomNum >= 10)
                    {
                        Console.WriteLine("Número inválido! Digite um número de 0 a 9.");
                    }
                    else
                    {
                        Console.WriteLine("Quarto já alugado! Escolha outro quarto:");
                    }
                    roomNum = int.Parse(Console.ReadLine());
                }

                Rooms[roomNum] = new StudentsInfo
                {
                    NameStudent = name,
                    EmailStudent = name.ToLower() + "@gmail.com"
                };
            }

            Console.WriteLine("\nResumo final das ocupações:");
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i] != null)
                {
                    Console.WriteLine($"Quarto {i} Ocupado por: {Rooms[i].NameStudent} - Email: {Rooms[i].EmailStudent}");
                }
                else
                {
                    Console.WriteLine($"Quarto {i}: Vago");
                }

            }
        }
    }
}