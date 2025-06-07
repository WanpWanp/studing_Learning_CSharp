// Importa funcionalidades básicas do .NET, como tipos primitivos e Console
using System;

// Importa recursos para manipulação de culturas e formatação de datas e números
using System.Globalization;

// Importa o namespace onde estão definidas as classes Comment e Post
using StringBuilderActivity.Entities;

namespace StringBuilderActivity // Define o namespace principal da aplicação
{
    // Classe principal do programa, com nível de acesso internal (visível apenas dentro do mesmo assembly)
    internal class Program
    {
        // Método Main: ponto de entrada do programa
        static void Main(string[] args)
        {
            // Aqui será escrito o código principal da aplicação,
            // como a criação de objetos Post e Comment, adição de comentários etc.

            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome!");

            Post post1 = new Post
            (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good night!");
            Comment comment4 = new Comment("May the Force be with you.");

            Post post2 = new Post
            (
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
            );

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            /*// Exibe os detalhes do primeiro post
            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Likes + "Likes - " + post1.Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            Console.WriteLine(post1.Content);
            Console.WriteLine("Comments:");
            foreach (Comment comment in post1.Comment)
            {
                Console.WriteLine(comment.Text);
            }
            Console.WriteLine();

            // Exibe os detalhes do segundo post
            Console.WriteLine(post2.Title);
            Console.WriteLine(post2.Likes + " Likes - " + post2.Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            Console.WriteLine(post2.Content);
            Console.WriteLine("Comments:");
            foreach (Comment comment in post2.Comment)
            {
                Console.WriteLine(comment.Text);

            }*/
            // Exibe os detalhes dos posts utilizando o método ToString sobrescrito na classe Post
            Console.WriteLine(post1);
            Console.WriteLine();
            Console.WriteLine(post2);
        }
    }
}
