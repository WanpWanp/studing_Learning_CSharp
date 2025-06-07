// Importa funcionalidades básicas do .NET, como tipos primitivos e datas
using System;

// Importa classes para trabalhar com coleções genéricas, como List<T>
using System.Collections.Generic;

// Importa operadores de consulta LINQ para coleções (não está sendo usado neste arquivo)
using System.Linq;

// Importa funcionalidades para manipulação de texto (não está sendo usado neste arquivo)
using System.Text;

// Importa recursos para programação assíncrona, como Task e async/await (não está sendo usado neste arquivo)
using System.Threading.Tasks;

namespace WorkerActivity.Entities
{
    // Classe que representa um contrato por hora de um trabalhador
    internal class HourContract
    {
        // Data em que o contrato foi realizado
        public DateTime Date { get; set; }

        // Valor pago por hora de trabalho
        public double ValuePerHour { get; set; }

        // Número total de horas contratadas
        public int Hours { get; set; }

        // Construtor padrão (sem parâmetros)
        public HourContract() { }

        // Construtor que inicializa um contrato com data, valor por hora e quantidade de horas
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Método que calcula o valor total do contrato com base nas horas e valor por hora
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
