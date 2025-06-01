// Importa funcionalidades básicas do .NET, como tipos primitivos, datas, etc.
using System;

// Importa classes para trabalhar com coleções genéricas, como List<T>, Dictionary<TKey, TValue>, etc.
using System.Collections.Generic;

// Importa funcionalidades para realizar operações com LINQ (consulta a coleções).
using System.Linq;

// Importa funcionalidades para manipulação de texto e codificação de caracteres.
using System.Text;

// Importa recursos relacionados à programação assíncrona, como Task e async/await.
using System.Threading.Tasks;

namespace WorkerActivity.Entities
{
    // Classe que representa um departamento dentro da aplicação
    internal class Departaments
    {
        // Propriedade que armazena o nome do departamento
        public string Name { get; set; }

        // Construtor padrão (sem parâmetros)
        public Departaments()
        {
        }

        // Construtor que permite inicializar o departamento com um nome
        public Departaments(string name)
        {
            Name = name;
        }
    }
}
