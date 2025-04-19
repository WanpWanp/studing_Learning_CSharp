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
        private int _qtdProd;
        private double _precoProd;

        public Produto()
        {
        }

        public Produto(string nome_Prod, int qtd_Prod, double preco_Prod)
        {
            _nomeProd = nome_Prod;
            _qtdProd = qtd_Prod;
            _precoProd = preco_Prod;
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

        public double Preco
        {
            get { return _precoProd; }
        }
        public int Quantidade
        {
            get { return _qtdProd; }
            set
            {
                _qtdProd = value;
            }
        }

        public void AddEstoqe(int quantidade)
        {
            _qtdProd += quantidade;

        }

        public void BaixaEstoque(int quantidade)
        {
            _qtdProd -= quantidade;
        }

        public string EstoqueAtualizado()
        {

            return $"A quantidade atualizada é: {_qtdProd}";
        }

        public double ValorEstoque()
        {

            return _qtdProd * _precoProd;
        }

        public override string ToString()
        {
            return $"{_nomeProd} " +
                $"R$ {_precoProd.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"Quantidade no estoque {_qtdProd} " +
                $"Valor total em estoque R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}