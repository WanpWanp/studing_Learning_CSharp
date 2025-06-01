// Importa os namespaces necessários para funcionalidades básicas do .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Importa o namespace do próprio projeto onde a entidade está definida
using StringBuilderActivity.Entities;

namespace StringBuilderActivity.Entities // Define o namespace onde a classe está inserida
{
    // Declara a classe Comment que representa um comentário
    class Comment
    {
        // Propriedade pública chamada Text, que armazena o conteúdo textual do comentário
        public string Text { get; set; }

        // Construtor padrão (sem parâmetros) - necessário para permitir a criação de objetos sem valores iniciais
        public Comment()
        {
        }

        // Construtor com parâmetro - permite criar o objeto já com o texto definido
        public Comment(string text)
        {
            Text = text; // Atribui o valor recebido ao atributo Text
        }
    }
}
