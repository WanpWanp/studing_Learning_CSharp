// Importações básicas do .NET

// Fornece funcionalidades fundamentais como Console, DateTime, tipos primitivos etc.
using System;

// Importa estruturas de dados como List, Dictionary (não utilizadas neste arquivo)
using System.Collections.Generic;

// Importa funcionalidades LINQ (não usadas neste arquivo)
using System.Linq;

// Importa recursos para manipulação de strings (não utilizados aqui, mas úteis com StringBuilder, etc.)
using System.Text;

// Importa recursos para programação assíncrona (não usados neste arquivo)
using System.Threading.Tasks;

// Importações abaixo não são necessárias aqui, pois não há uso direto de outras entidades ou enums:
// using OrderSystem.Entities;
// using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities // Define o namespace da classe Product
{
    // Classe Product representa um produto no sistema
    internal class Product
    {
        // Nome do produto
        public string Name { get; set; }

        // Preço do produto
        public double Price { get; set; }

        // Construtor padrão (sem parâmetros) — necessário para criação sem valores iniciais
        public Product() { }

        // Construtor que recebe nome e preço para inicialização direta
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /*
        // Campos adicionais comentados, sugerindo possíveis expansões da classe:

        // Identificador único do produto
        public int Id { get; set; }

        // Descrição do produto
        public string Description { get; set; }

        // Categoria (roupa, eletrônicos, alimentos etc.)
        public string Category { get; set; }

        // Construtor completo incluindo ID, nome, preço, descrição e categoria
        public Product(int id, string name, double price, string description, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        */
    }
}
