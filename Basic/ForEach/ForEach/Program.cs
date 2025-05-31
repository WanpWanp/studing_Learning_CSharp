using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;

namespace ForEache
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] vect = new string[]
            {
                "Ana",
                "Axl",
                "Theo"
            };

            foreach (string names in  vect) {
                Console.WriteLine(names);
            }*/

            List<string> list = new List<string>();
            List<string> list2 = new List<string>{
                "Ana",
                "Theo",
                "Angel",
                "Tommy",
                "Patrick"
            };

            list.Add("João");
            list.Add("Maria");
            list.Add("Tadeu");
            Console.WriteLine("Nomes lista 1:");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");

            list.Insert(1, "Teresinha");

            Console.WriteLine("Nomes atualziados da lista 1:");
            foreach (string item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");
            /*string s1 = list.FindAll(x => x[0] == 'T');
            Console.WriteLine(s1);*/
            int pos = list.FindIndex(x => x[0] == 'T');
            Console.WriteLine(pos);

            List<string> list3 = list.FindAll(x => x.Length == 5);
            
            foreach (string item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Usando remove");

            list2.RemoveAt(1);
            list2.RemoveRange(0, 1);

            foreach (string item in list2) { Console.WriteLine($"Lista 2: {item}"); }

            list.Remove("Tadeu");
            Console.WriteLine();
            foreach (string item in list) {  
                Console.WriteLine(item);
            }

            Console.WriteLine("\nUsando removeall");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list) {  
                Console.WriteLine(item); 
            }

            Console.WriteLine("\nUsando removeat");

            
        }
    }
}