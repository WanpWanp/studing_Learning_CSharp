using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ControleEstoque
{
    internal class Produto
    {
        private string _nomeProd;
        public int QtdProd { get; private set; }
        public double PrecoProd { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome_Prod, int qtd_Prod, double preco_Prod)
        {
            _nomeProd = nome_Prod;
            QtdProd = qtd_Prod;
            PrecoProd = preco_Prod;
        }

        public string Nome
        {
            get { return _nomeProd; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeProd = value;
                }
                else
                {
                    Console.WriteLine("Caracteres necessário para atribuir novo nome no produto é de no minimo 2!");
                }
            }

        }

        public void AddEstoqe(int quantidade)
        {
            QtdProd += quantidade;

        }

        public void BaixaEstoque(int quantidade)
        {
            QtdProd -= quantidade;
        }

        public string EstoqueAtualizado()
        {

            return $"A quantidade atualizada é: {QtdProd}";
        }

        public double ValorEstoque()
        {

            return QtdProd * PrecoProd;
        }

        public override string ToString()
        {
            return $"{_nomeProd} " +
                $"R$ {PrecoProd.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"Quantidade no estoque {QtdProd} " +
                $"Valor total em estoque R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}