using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string GetNome() { 
            return _nomeProd;
        }

        public void SetNome(string prodNome)
        {
            if (prodNome != null && prodNome.Length > 1)
            {
                _nomeProd = prodNome;
            }
            else {
                Console.WriteLine("Tamanho minimo para nome deve ser 2 caracteres");
            }
        }

        public double GetPreco() { 
            return _precoProd;
        }

        public void SetPreco(double preco) { 
            _precoProd = preco; 
        }

        public int GetQuantidade() { 
            return _qtdProd; 
        }

        public void SetQuantidade(int quantidade)
        {
            _qtdProd = quantidade;
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
