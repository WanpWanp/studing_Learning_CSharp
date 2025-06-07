// Importa funcionalidades básicas do .NET (ex: tipos primitivos e enumerações)
using System;

// Importa classes para trabalhar com coleções genéricas (não está sendo usado neste arquivo)
using System.Collections.Generic;

// Importa operadores LINQ (não está sendo usado neste arquivo)
using System.Linq;

// Importa funcionalidades para manipulação de texto (não está sendo usado neste arquivo)
using System.Text;

// Importa recursos para programação assíncrona (não está sendo usado neste arquivo)
using System.Threading.Tasks;

namespace WorkerActivity.Entities.Enums
{
    // Enumeração que representa os níveis de um trabalhador
    enum WorkerLevel : int
    {
        // Trabalhador júnior (nível inicial)
        Junior = 0,

        // Trabalhador de nível intermediário
        MidLevel = 1,

        // Trabalhador sênior (nível avançado)
        Senior = 2
    }
}
