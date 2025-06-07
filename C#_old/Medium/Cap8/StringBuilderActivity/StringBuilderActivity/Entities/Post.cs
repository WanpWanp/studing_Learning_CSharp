// Importa namespaces necessários para o funcionamento da aplicação
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // Importa o namespace para manipulação de culturas e formatação de datas e números

// Importa a definição da classe Comment localizada na pasta Entities
using StringBuilderActivity.Entities;

namespace StringBuilderActivity.Entities // Define o namespace onde essa classe está contida
{
    // Classe Post representa uma postagem, como em uma rede social
    internal class Post
    {
        // Propriedade que armazena o momento (data e hora) da postagem
        public DateTime Moment { get; set; }

        // Título da postagem
        public string Title { get; set; }

        // Conteúdo (texto principal) da postagem
        public string Content { get; set; }

        // Número de curtidas da postagem
        public int Likes { get; set; }

        // Lista de comentários relacionados à postagem
        public List<Comment> Comment { get; set; } = new List<Comment>();

        // Construtor padrão (sem parâmetros) - necessário para instanciar a classe sem valores iniciais
        public Post() { }

        // Construtor com parâmetros - permite inicializar um objeto Post com dados desde a criação
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment; // Define o momento da postagem
            Title = title;   // Define o título
            Content = content; // Define o conteúdo
            Likes = likes;   // Define o número de curtidas
        }

        // Método para adicionar um comentário à lista de comentários
        public void AddComment(Comment comment)
        {
            Comment.Add(comment);
        }

        // Método para remover um comentário da lista de comentários
        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);
        }

        // Método ToString sobrescrito para retornar uma representação textual da postagem
        public override string ToString()
        {
            // Cria um StringBuilder para construir a string de forma eficiente
            StringBuilder sb = new StringBuilder();
            // Adiciona o título, número de curtidas e data formatada
            sb.AppendLine(Title);
            sb.AppendLine(Likes + " Likes - " + Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            // Adiciona o conteúdo da postagem
            sb.AppendLine(Content);
            // Adiciona os comentários, se houver
            sb.AppendLine("Comments:");
            foreach (Comment comment in Comment)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString(); // Retorna a string construída
        }
    }
}

