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
        public string NomeProd;
        public int QtdProd;
        public double PrecoProd;

        public Produto(string nome_Prod, int qtd_Prod, double preco_Prod)
        {
            NomeProd = nome_Prod;
            QtdProd = qtd_Prod;
            PrecoProd = preco_Prod;
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
            return $"{NomeProd} " +
                $"R$ {PrecoProd.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"Quantidade no estoque {QtdProd} " +
                $"Valor total em estoque R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
