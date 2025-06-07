using System;
using System.Runtime.Intrinsics.X86;


namespace MagicTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array to hold the milhar values
            int[] milhares = new int[6]; // [milhar1, milhar2, IA1, milhar3, IA2, totalSum]

            // Function to read and validate a 4-digit number
            int ReadMilhar(string message)
            {
                int value;
                while (true)
                {
                    Console.Write(message);
                    string input = Console.ReadLine();

                    // Check if input is a number between 0 and 9999 (4 digits max)
                    if (int.TryParse(input, out value) && value >= 0 && value <= 9999 && input.Length <= 4)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid milhar! Enter a numeric value with 4 digits (0000 to 9999), no letters or negatives.");
                    }
                }
            }

            // === Read first milhar ===
            milhares[0] = ReadMilhar("Enter the first milhar (e.g., 1000): ");
            int result1 = (milhares[0] - 2) + 20000;
            Console.WriteLine($"The final result will be: {result1}");

            // === Read second milhar and ensure IA1 = 9999 - milhar2 ===
            while (true)
            {
                milhares[1] = ReadMilhar("Enter the second milhar (e.g., 2000): ");
                milhares[2] = 9999 - milhares[1];

                if (milhares[1] + milhares[2] == 9999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error! The sum of the second milhar and IA1 must equal 9999. Try again.");
                }
            }
            Console.WriteLine($"System milhar (IA1): {milhares[2]:D4}");

            // === Read third milhar and ensure IA2 = 9999 - milhar3 ===
            while (true)
            {
                milhares[3] = ReadMilhar("Enter the third milhar (e.g., 3000): ");
                milhares[4] = 9999 - milhares[3];

                if (milhares[3] + milhares[4] == 9999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error! The sum of the third milhar and IA2 must equal 9999. Try again.");
                }
            }
            Console.WriteLine($"System milhar (IA2): {milhares[4]:D4}");

            // === Calculate total sum ===
            milhares[5] = milhares[0] + milhares[1] + milhares[2] + milhares[3] + milhares[4];

            // === Final output (always with 4 digits using :D4) ===
            Console.WriteLine("\nMilhar Summary:");
            Console.WriteLine($"Milhar 01 : {milhares[0]:D4}");
            Console.WriteLine($"Milhar 02 : {milhares[1]:D4}");
            Console.WriteLine($"Milhar IA1: {milhares[2]:D4}");
            Console.WriteLine($"Milhar 03 : {milhares[3]:D4}");
            Console.WriteLine($"Milhar IA2: {milhares[4]:D4}");
            Console.WriteLine($"Total sum : {milhares[5]}");
        }
    }
}
