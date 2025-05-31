using System;
using System.Globalization;

namespace FuncoesInteressantes
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "abcde FGHIJ ABC abc DEFG  hij DE";
            Console.WriteLine($"Original: {original}");
            string s1 = original.ToUpper();
            Console.WriteLine($"Tudo em maiusculo: {s1}.");
            string s2 = original.ToLower();
            Console.WriteLine($"tudo em minusculo: {s2}.");
            string s3 = original.Trim();
            Console.WriteLine($"Limpando espaçços em branco sem uso:  {s3}.");
            int n1 = original.IndexOf("DE");
            Console.WriteLine($"Encontrando a ocorrencia (posição) de 'DE' com IdexOf {n1}");
            int n2 = original.LastIndexOf("DE");
            Console.WriteLine($"Encontrando a última ocorrencia (posiçã) de 'DE' com IdexOf {n2}");
            string s4 = original.Substring(3);
            Console.WriteLine($"Recortando a matriz apenas com indice a partir de {original[3]}: {s4}");
            string s5 = original.Substring(3, 6);
            Console.WriteLine($"Recortando a matriz apenas com indice a partir de {original[3]} mas limitado a 6 caracteres: {s5}");
            string s6 = original.Replace('b', 'W');
            Console.WriteLine($"Substituindo a letra b por W: {s6}");
            string s7 = original.Replace("ABC", "KWY");
            Console.WriteLine($"Substituindo as letras ABC por KWY: {s7}");

            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine($"Testando se a matriz ou string é nula ou vazia: {b1}");
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine($"Testando se a matriz ou string é espaço em branco: {b2}");

        }
    }
}