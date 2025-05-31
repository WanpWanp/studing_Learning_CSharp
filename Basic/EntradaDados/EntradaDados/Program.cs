using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, dadosNome;
            int QtdQuarto, dadosIdade;
            double ProdPreco, dadosAltura;
            string[] dados;

            /* string[] dados;
             string nome, sexo;
             int idade;
             double altura;
             int n1, n2;
             n1 = int.Parse(Console.ReadLine());
             n2 = int.Parse(Console.ReadLine());
             char ch = char.Parse(Console.ReadLine());
             double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             string frase, x, y, z, a, b, c;


             Console.WriteLine("Digite sua frase!");
             frase = Console.ReadLine();

             Console.WriteLine($"Você digitou {frase}");

             Console.WriteLine("Digite sua cor favorita!");
             x = Console.ReadLine();

             Console.WriteLine("Digite sua segunda cor favorita!");
             y = Console.ReadLine();

             Console.WriteLine("Digite sua terceira cor favorita!");
             z = Console.ReadLine();

             Console.WriteLine($"Sua cor favorita informada foi {x}, a segunda cor  {y} e a terceira {z}!");

             Console.WriteLine("Digite trê paises com a letra B!");
             string[] vet = Console.ReadLine().Split(' ');
             a = vet[0];
             b = vet[1];
             c = vet[2];
             Console.WriteLine($"Primeiro páis digitado com letra B foi {a}, segundo foi {b} e o ultimo foi {c}!");
             Console.WriteLine("Numero digitado {0}", n1);
             Console.WriteLine("Numero digitado {0}", n2);
             Console.WriteLine($"A soma de {n1} e {n2} é {n1 + n2}");
             Console.WriteLine(ch);
             Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine(d.ToString("C", new CultureInfo("pt-BR")));

             Console.WriteLine("Informe o seu nome, idade sexo e altura");
             dados = Console.ReadLine().Split(' ');
             nome = dados[0];
             idade = int.Parse(dados[1]);
             sexo = dados[2];
             altura = double.Parse(dados[3]);
             Console.WriteLine($"Seu nome é {nome} com idade {idade}, altura {altura} do genero {(sexo == "m" ? "Masculino" : "Feminino")}");
             Console.WriteLine(dados[0], dados[1]);*/

            Console.WriteLine("Entre com seu nome completo!");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            QtdQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            ProdPreco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha)");
            dados = Console.ReadLine().Split(' ');

            dadosNome = dados[0];
            dadosIdade = int.Parse(dados[1]);
            dadosAltura = double.Parse(dados[2]);
            

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(QtdQuarto);
            Console.WriteLine(ProdPreco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(dadosNome);
            Console.WriteLine(dadosIdade);
            Console.WriteLine(dadosAltura.ToString(CultureInfo.InvariantCulture));
            

        }
    }
}